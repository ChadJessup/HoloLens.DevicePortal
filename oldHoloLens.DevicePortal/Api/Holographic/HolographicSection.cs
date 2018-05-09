
namespace HoloLens.DevicePortal.Api.Holographic
{
    using HoloLens.DevicePortal.Api.Holographic.Perception;

    public class HolographicSection
    {
        public PerceptionSection Perception { get; } = new PerceptionSection();
    }
}
