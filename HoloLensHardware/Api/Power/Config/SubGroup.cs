
namespace HoloLens.Hardware.Api.Power.Config
{
    using System;
    using System.Collections.Concurrent;

    public class SubGroup
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public Guid GUID { get; set; }
        public bool IsHidden { get; set; }

        public ConcurrentBag<Setting> Settings { get; } = new ConcurrentBag<Setting>();

        public override string ToString()
        {
            return $"{this.Alias} - {this.FriendlyName}";
        }
    }
}
