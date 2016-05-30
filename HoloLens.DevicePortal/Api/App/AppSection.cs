namespace HoloLens.DevicePortal.Api.App
{
    using HoloLens.DevicePortal.Api.App.PackageManager;

    public class AppSection
    {
        public PackageManagerSection PackageManager { get; } = new PackageManagerSection();
    }
}
