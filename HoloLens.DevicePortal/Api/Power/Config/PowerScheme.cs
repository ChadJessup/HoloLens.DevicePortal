using System.Collections.Concurrent;

namespace HoloLens.DevicePortal.Api.Power.Config
{
    public class PowerScheme
    {
        public ConcurrentBag<SubGroup> SubGroups { get; } = new ConcurrentBag<SubGroup>();
    }
}
