
namespace HoloLens.DevicePortal.Helpers
{
    using System.Numerics;

    public static class Math3dHelpers
    {
        // TODO: Port from: https://github.com/mrdoob/three.js/blob/master/src/math/Matrix4.js
        public static Matrix4x4 Transpose (this Matrix4x4 te)
        {
            Vector4 tmp;
            //Matrix4x4 v = new Matrix4x4()
            //tmp = te.M11; te.M11 = te.M4; te.M4 = tmp;
            //tmp = te.M2; te.M2 = te.M8; te.M8 = tmp;
            //tmp = te.M6; te.M6 = te.M9; te.M9 = tmp;

            //tmp = te.M3; te.M3 = te.M12; te.M12 = tmp;
            //tmp = te.M7; te.M7 = te.M13; te.M13 = tmp;
            //tmp = te.M11; te.M11 = te.M14; te.M14 = tmp;

            return te;
        }
    }
}
