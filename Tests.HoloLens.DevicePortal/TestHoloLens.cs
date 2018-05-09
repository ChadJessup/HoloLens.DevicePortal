using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace Tests.HoloLens.DevicePortal
{
    public class TestHoloLens
    {
        public TestHoloLens(string testFilePath = "./hololensTest.json")
        {
            if (!File.Exists(testFilePath))
            {
                throw new InvalidOperationException($"Unable to load test file with address/credentials: {testFilePath}");
            }

            JsonConvert.PopulateObject(File.ReadAllText(testFilePath), this);
            this.Credentials = new NetworkCredential(this.TestUsername, this.TestPassword);
        }

        public string Address = "http://192.168.1.186";
        public string TestUsername = "test";
        public string TestPassword = "1234567";
        public NetworkCredential Credentials { get; set; }
    }
}
