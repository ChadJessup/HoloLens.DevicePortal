
namespace HoloLens.DevicePortal.Api.Power
{
    using Newtonsoft.Json;
    using System;

    public class ActivePowerScheme
    {
        [JsonProperty(PropertyName = "ActivePowerScheme")]
        public Guid  Id { get; set; }
    }
}
