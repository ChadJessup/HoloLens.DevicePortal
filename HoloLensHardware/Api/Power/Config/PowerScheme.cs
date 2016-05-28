
namespace HoloLens.Hardware.Api.Power.Config
{
    using System.Collections.Concurrent;

    public class PowerScheme
    {
        public ConcurrentBag<SubGroup> SubGroups { get; } = new ConcurrentBag<SubGroup>();
    }
}
