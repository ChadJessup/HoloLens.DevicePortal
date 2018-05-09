using System;

namespace Tests.HoloLens.DevicePortal
{
    public static class TestFixture
    {
        private static object lockObj = new object();

        static TestFixture()
        {
            lock (lockObj)
            {
                if (TestFixture.Context == null)
                {
                    TestFixture.Context = new TestHoloLens();
                }
            }
        }

        public static TestHoloLens Context { get; private set; }
    }
}
