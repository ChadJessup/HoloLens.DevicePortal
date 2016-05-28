namespace HoloLens.Hardware.Api.Power.Config
{
    public class ValueSetting : PowerBase
    {
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
    }
}
