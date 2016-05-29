
namespace HoloLens.DevicePortal.Api.Wpr
{
    using Newtonsoft.Json;
    using System.Threading.Tasks;

    public class WindowsPerformanceRecorderSection
    {
        private static class Constants
        {
            public const string StatusUri = "/api/wpr/status";
        }

        public async Task<WprStatus> GetWprStatusAsync()
        {
            var content = await HoloLensHttpHelpers.GetContentAsync(Constants.StatusUri);

            return await Task.Run(() => JsonConvert.DeserializeObject<WprStatus>(content));
        }
    }
}
