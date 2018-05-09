using Newtonsoft.Json;
using System;

namespace HoloLens.DevicePortal.Api.Power
{
    public class ActivePowerScheme
    {
        [JsonProperty(PropertyName = "ActivePowerScheme")]
        public Guid  Id { get; set; }
    }
}
