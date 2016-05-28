
namespace HoloLens.Hardware.Api.Power.Config
{
    using Newtonsoft.Json;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;

    public class ConfigSection
    {
        private static class Constants
        {
            public const string SchemeCurrentUri = "/api/power/cfg/scheme_current";
        }

        public async Task<PowerScheme> GetCurrentSchemeAsync()
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

                var response = await client.GetAsync(Constants.SchemeCurrentUri);
                var content = await response.Content.ReadAsStringAsync();

                return await Task.Run(() => JsonConvert.DeserializeObject<PowerScheme>(content));
            }
        }
    }
}
