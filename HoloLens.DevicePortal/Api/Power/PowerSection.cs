
namespace HoloLens.DevicePortal.Api.Power
{
    using Config;
    using Newtonsoft.Json;
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

        public async Task<ActivePowerScheme> GetActivePowerSchemeIdAsync()
        {
            var content = await HoloLensHttpHelpers.GetContentAsync(Constants.ActiveConfigurationUri);

            return JsonConvert.DeserializeObject<ActivePowerScheme>(content);
        }

        public async Task<PowerState> GetPowerStateAsync()
        {
            var content = await HoloLensHttpHelpers.GetContentAsync(Constants.StateUri);

            return JsonConvert.DeserializeObject<PowerState>(content);
        }

        public async Task<Battery> GetBatteryAsync()
        {
            var content = await HoloLensHttpHelpers.GetContentAsync(Constants.BatteryUri);

            return JsonConvert.DeserializeObject<Battery>(content);
        }
    }
}
