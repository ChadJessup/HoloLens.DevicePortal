﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace HoloLens.DevicePortal.Api.ResourceManager
{
    using System.Threading.Tasks;

    public class ResourceManagerSection
    {
        private static class Constants
        {
            public const string ActiveProcessesUri = "/api/resourcemanager/processes";
        }

        public async Task<List<HoloLensProcess>> GetActiveProcessesAsync()
        {
            var content = await HoloLensHttpHelpers.GetContentAsync(Constants.ActiveProcessesUri);
            var jsonObject = JObject.Parse(content)["Processes"];

            return await Task.Run(() => jsonObject.ToObject<List<HoloLensProcess>>());
        }
    }
}
