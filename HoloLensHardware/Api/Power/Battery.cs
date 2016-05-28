namespace HoloLens.Hardware.Api.Power
{
    // https://msdn.microsoft.com/en-us/library/windows/desktop/aa373212(v=vs.85).aspx
    public class Battery
    {
        public int AcOnline { get; set; }
        public int BatteryPresent { get; set; }
        public int Charging { get; set; }
        public int DefaultAlert1 { get; set; }
        public int DefaultAlert2 { get; set; }
        public long EstimatedTime { get; set; }
        public int MaximumCapacity { get; set; }
        public int RemainingCapacity { get; set; }
    }
}
