using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HoloLens.DevicePortal
{
    public static class HoloLensHttpHelpers
    {
        public async static Task<string> GetContentAsync(string endpoint)
        {
            using (HttpClient client = new HttpClient(new HttpClientHandler()
            {
                ClientCertificateOptions = ClientCertificateOption.Automatic,
                Credentials = HoloLensHardware.Credentials,
            }))
            {
                client.BaseAddress = HoloLensHardware.HardwareAddress;

                var response = await client.GetAsync(endpoint);
                return await response.Content.ReadAsStringAsync();
            }
        }

        internal static Task GetContentAsync(object installationStateUri)
        {
            throw new NotImplementedException();
        }
    }
}
