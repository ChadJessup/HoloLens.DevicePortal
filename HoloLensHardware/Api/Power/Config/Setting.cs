
namespace HoloLens.Hardware.Api.Power.Config
{
    using System;
    using System.Collections.Generic;

    public class Setting
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public Guid GUID { get; set; }
        public bool IsHidden { get; set; }
        public long ValueAC { get; set; }
        public long ValueDC { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public long Min { get; set; }
        public string Units { get; set; }

        public List<object> Possible { get; } = new List<object>();

        public override string ToString()
        {
            return $"{this.Alias} - {this.FriendlyName}";
        }
    }
}
