
namespace HoloLens.Hardware.Api.Power
{
    using Config;
    using Newtonsoft.Json;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class PowerSection
    {
        private static class Constants
        {
            public const string ActiveConfigurationUri = "/api/power/activecfg";
            public const string StateUri = "/api/power/state";
            public const string BatteryUri = "/api/power/battery";
        }

        public ConfigSection Config { get; set; } = new ConfigSection();

        public async Task<PowerState> GetPowerStateAsync()
        {
            ICredentials creds = new NetworkCredential("test", "1234567");

            using (HttpClient client = new HttpClient(
                new HttpClientHandler()
                {
                    ClientCertificateOptions = ClientCertificateOption.Automatic,
                     Credentials = creds,
                }))
            {
                client.BaseAddress = HoloLensHardware.HardwareAddress;

                var response = await client.GetAsync(Constants.StateUri);
                var content = await response.Content.ReadAsStringAsync();

                return await Task.Run(() => JsonConvert.DeserializeObject<PowerState>(content));
            }
        }

        public async Task<Battery> GetBatteryAsync()
        {
            ICredentials creds = new NetworkCredential("test", "1234567");

            using (HttpClient client = new HttpClient(
                new HttpClientHandler()
                {
                    ClientCertificateOptions = ClientCertificateOption.Automatic,
                    Credentials = creds,
                }))
            {
                client.BaseAddress = HoloLensHardware.HardwareAddress;

                var response = await client.GetAsync(Constants.BatteryUri);
                var content = await response.Content.ReadAsStringAsync();

                return await Task.Run(() => JsonConvert.DeserializeObject<Battery>(content));
            }
        }
    }
}
