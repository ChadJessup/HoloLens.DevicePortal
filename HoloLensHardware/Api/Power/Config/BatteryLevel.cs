namespace HoloLens.Hardware.Api.Power.Config
{
    public class BatteryLevel
    {
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }
}
