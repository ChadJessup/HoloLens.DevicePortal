using System;

namespace HoloLens.DevicePortal.Api.App.PackageManager
{
    public class InstalledPackage
    {
        public string Name { get; set; }
        public string PackageFamilyName { get; set; }
        public string PackageFullName { get; set; }
        public int PackageOrigin { get; set; }
        public string PackageRelativeId { get; set; }
        public string Publisher { get; set; }
        public Version Version { get; set; }

        public override string ToString()
        {
            return $"{this.Name}";
        }
    }
}