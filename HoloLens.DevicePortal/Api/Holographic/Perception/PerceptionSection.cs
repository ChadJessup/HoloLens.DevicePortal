using HoloLens.DevicePortal.Api.Holographic.Perception.SurfaceReconstruction;
using System.Threading.Tasks;

namespace HoloLens.DevicePortal.Api.Holographic.Perception
{
    public class PerceptionSection
    {
        public async Task<SurfaceReconstructionBuilder> StartSurfaceReconstruction()
        {
            var sr = new SurfaceReconstructionBuilder(HoloLensHardware.HardwareAddress, HoloLensHardware.Credentials);
            await sr.StartGatheringAllDataAsync();

            return sr;
        }
    }
}
