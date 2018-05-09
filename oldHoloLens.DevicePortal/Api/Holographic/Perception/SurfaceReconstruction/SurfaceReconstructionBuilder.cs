
namespace HoloLens.DevicePortal.Api.Holographic.Perception.SurfaceReconstruction
{
    using HoloLens.DevicePortal.Converters;
    using HoloLens.DevicePortal.Models;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Net;
    using System.Net.WebSockets;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    // A lot of code based upon: https://gist.github.com/xamlmonkey/4737291
    public class SurfaceReconstructionBuilder
    {
        private static class Constants
        {
            public const string ClientUri = "/api/holographic/perception/client"; //?clientmode=passive";

            public const string ClientModeQueryString = "?clientmode=";

            public const string GetSRData = "getsrdata";

            public const string SurfaceObserverPropertyName = "SurfaceObserverStatus";
            public const string TrackingStatePropertyName = "TrackingState";
            public const string SurfacePropertyName = "Surface";
        }

        private CancellationTokenSource tokenSource = new CancellationTokenSource();
        private CancellationToken cancellationToken;
        private ClientWebSocket webSocket;
        private Uri websocketEndpoint;
        private JsonSerializer serializer;

        private bool getLiveDetails = false;
        private bool getSRData = false;

        public EventHandler<SurfaceReconstructionDetailsEventArgs> OnLiveDetailsReceived { get; set; }
        public EventHandler<SurfaceReconstructedEventArgs> OnSurfaceReceived { get; set; }

        public SurfaceReconstructionBuilder(Uri holoLensAddress, NetworkCredential credentials)
        {
            var url = holoLensAddress + Constants.ClientUri + Constants.ClientModeQueryString +"passive";
            this.webSocket = new ClientWebSocket();
            this.webSocket.Options.Credentials = credentials;
            this.websocketEndpoint = new Uri(url.Replace("http", "ws"));

            this.serializer = new JsonSerializer();

            this.serializer.FloatParseHandling = FloatParseHandling.Decimal;
            this.serializer.Culture = new CultureInfo(string.Empty) { NumberFormat = new NumberFormatInfo {  NumberDecimalDigits = 7 } };

            this.serializer.Converters.Add(new Vector4Converter());
            this.serializer.Converters.Add(new Matrix4x4Converter());
            this.serializer.Converters.Add(new SurfaceConverter());
        }

        public async Task StartLiveDetailsAsync()
        {
            this.getLiveDetails = true;

            await Task.Run(() => this.StartListenAsync());
        }

        public async Task StartReconstructionAsync()
        {
            this.getSRData = true;

            await Task.Run(() => this.SendMessageAsync(Constants.GetSRData))
                .ContinueWith((o)=> this.StartListenAsync());
        }

        public Task StartGatheringAllDataAsync()
        {
            this.getLiveDetails = true;
            this.getSRData = true;

            return Task.Run(() => this.SendMessageAsync(Constants.GetSRData))
                .ContinueWith((o) => this.StartListenAsync());
        }

        private async Task<bool> ConnectWebSocket()
        {
            if (this.webSocket.State == WebSocketState.Open)
            {
                return true;
            }

            this.cancellationToken = this.tokenSource.Token;

            // TODO: chadj - 5/29/16 - fill in negatives once you know what they are...
            await this.webSocket.ConnectAsync(this.websocketEndpoint, this.cancellationToken);

            return true;
        }

        private async Task StartListenAsync()
        {
            await this.ConnectWebSocket();

            var buffer = new byte[1024];

            try
            {
                while (this.webSocket.State == WebSocketState.Open)
                {
                    var stringResult = new StringBuilder();

                    WebSocketReceiveResult result;
                    do
                    {
                        result = await this.webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), this.cancellationToken);

                        if (result.MessageType == WebSocketMessageType.Close)
                        {
                            await this.webSocket.CloseAsync(WebSocketCloseStatus.NormalClosure, string.Empty, CancellationToken.None);
                        }
                        else
                        {
                            stringResult.Append(Encoding.UTF8.GetString(buffer, 0, result.Count));
                        }

                    } while (!result.EndOfMessage);

                    this.ParseMessage(stringResult.ToString());
                }
            }
            catch (Exception e)
            {
                //CallOnDisconnected();
            }
            finally
            {
                this.webSocket.Dispose();
            }
        }

        private void ParseMessage(string srJson)
        {
            JObject response = JObject.Parse(srJson);

            if (this.getLiveDetails && response.Properties().Any(prop => prop.Name == Constants.TrackingStatePropertyName))
            {
                Task.Run(() => 
                    this.OnLiveDetailsReceived?.Invoke(
                        this, 
                        new SurfaceReconstructionDetailsEventArgs(
                            response.ToObject<SurfaceReconstructionDetails>(this.serializer))));
            }

            if (this.getSRData && response.Properties().Any(prop => prop.Name == Constants.SurfaceObserverPropertyName))
            {
                if (response[Constants.SurfaceObserverPropertyName].ToString() == "OK")
                {
                    Task.Run(() =>
                    this.OnSurfaceReceived?.Invoke(
                        this,
                        new SurfaceReconstructedEventArgs(
                            response[Constants.SurfacePropertyName].ToObject<Surface>(this.serializer))));
                }
            }
        }

        private async Task SendMessageAsync(string message)
        {
            await this.ConnectWebSocket();
            await this.webSocket.SendAsync(
                new ArraySegment<byte>(Encoding.UTF8.GetBytes(message)),
                WebSocketMessageType.Text,
                endOfMessage: true,
                cancellationToken: this.cancellationToken);
        }
    }
}
