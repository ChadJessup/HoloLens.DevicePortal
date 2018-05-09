using System.Collections.Generic;

namespace HoloLens.DevicePortal.Api.App.PackageManager
{
    public class PackageManager
    {
        public List<InstalledPackage> InstalledPackages { get; } = new List<InstalledPackage>();
    }
}
