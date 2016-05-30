
namespace HoloLens.DevicePortal.Api.ResourceManager
{
    using System;

    public class HoloLensProcess
    {
        public double CPUUsage { get; set; }
        public string ImageName { get; set; }
        public int PageFileUsage { get; set; }
        public int PrivateWorkingSet { get; set; }
        public int ProcessId { get; set; }
        public int SessionId { get; set; }
        public string UserName { get; set; }
        public int VirtualSize { get; set; }
        public int WorkingSetSize { get; set; }
        public int? TotalCommit { get; set; }
        public string AppName { get; set; }
        public string PackageFullName { get; set; }
        public string Publisher { get; set; }

        public Version Version { get; set; }

        public override string ToString()
        {
            return $"{this.ImageName}";
        }
    }
}
