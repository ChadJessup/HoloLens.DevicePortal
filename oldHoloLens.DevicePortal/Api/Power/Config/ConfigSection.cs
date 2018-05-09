﻿
namespace HoloLens.DevicePortal.Api.Power.Config
{
    using System.Threading.Tasks;

    public class ConfigSection
    {
        private static class Constants
        {
            public const string SchemeCurrentUri = "/api/power/cfg/scheme_current";
        }

        public async Task<PowerScheme> GetCurrentSchemeAsync()
        {
            var content = await HoloLensHttpHelpers.GetContentAsync(Constants.SchemeCurrentUri);
            return await new PowerSchemeParser().ParseAsync(content);
        }
    }
}
