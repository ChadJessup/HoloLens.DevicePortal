using HoloLens.DevicePortal.Api.Holographic.Perception.SurfaceReconstruction;
using System.Threading.Tasks;

namespace HoloLens.DevicePortal.Api.Holographic.Perception
{
    public class PerceptionSection
    {
        public Task<SurfaceReconstructionBuilder> StartSurfaceReconstruction()
        {
            var sr = new SurfaceReconstructionBuilder(HoloLensHardware.HardwareAddress, HoloLensHardware.Credentials);
            sr.StartGatheringAllDataAsync();

            return Task.FromResult<SurfaceReconstructionBuilder>(sr);
        }
    }
}
