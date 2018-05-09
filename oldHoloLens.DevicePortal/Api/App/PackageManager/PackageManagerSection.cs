
namespace HoloLens.DevicePortal.Api.App.PackageManager
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Threading.Tasks;

    public class PackageManagerSection
    {
        private static class Constants
        {
            public const string PackagesUri = "/api/app/packagemanager/packages";
            public const string InstallationStateUri = "/api/app/packagemanager/state";
        }

        public async Task<PackageManager> GetInstalledPackagesAsync()
        {
            var content = await HoloLensHttpHelpers.GetContentAsync(Constants.PackagesUri);

            return await Task.Run(() => JsonConvert.DeserializeObject<PackageManager>(content));
        }

        public async Task<string> GetInstallationStateAsync()
        {
            var content = await HoloLensHttpHelpers.GetContentAsync(Constants.InstallationStateUri);

            return await Task.Run(() => JObject.Parse(content)["Reason"].ToString());
        }
    }
}
