
namespace HoloLens.Hardware.Api.OS
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class OSSection
    {
        private static class Constants
        {
            public const string InfoUri = "/api/os/info";
            public const string MachineNameUri = "/api/os/machinename";
        }

        public async Task<Info> GetInfoAsync()
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

                var response = await client.GetAsync(Constants.InfoUri);
                var content = await response.Content.ReadAsStringAsync();

                return await Task.Run(() => JsonConvert.DeserializeObject<Info>(content));
            }
        }

        public async Task<string> GetMachineNameAsync()
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

                var response = await client.GetAsync(Constants.InfoUri);
                var content = await response.Content.ReadAsStringAsync();

                return await Task.Run(() => JObject.Parse(content)["ComputerName"].ToString());
            }
        }
    }
}
