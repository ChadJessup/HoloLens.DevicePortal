using Newtonsoft.Json;
using System.Threading.Tasks;

namespace HoloLens.DevicePortal.Api.Wpr
{
    public class WindowsPerformanceRecorderSection
    {
        private static class Constants
        {
            public const string StatusUri = "/api/wpr/status";
        }

        public async Task<WprStatus> GetWprStatusAsync()
        {
            var content = await HoloLensHttpHelpers.GetContentAsync(Constants.StatusUri);

            return JsonConvert.DeserializeObject<WprStatus>(content);
        }
    }
}
