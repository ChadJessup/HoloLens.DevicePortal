
namespace HoloLens.Hardware.Api.Power.Config
{
    using Newtonsoft.Json;
    using System.Net;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;
    using System.IO;
    using Newtonsoft.Json.Linq;
    using System.Collections.Concurrent;

    public class ConfigSection
    {
        private static class Constants
        {
            public const string SchemeCurrentUri = "/api/power/cfg/scheme_current";
        }

        public async Task<PowerScheme> GetCurrentSchemeAsync()
        {
            ICredentials creds = new NetworkCredential("test", "1234567");

            using (HttpClient client = new HttpClient(
                new HttpClientHandler()
                {
                    ClientCertificateOptions = ClientCertificateOption.Automatic,
                    Credentials = creds,
                }))
            {
                client.BaseAddress = HoloLensHardware.HardwareAddress;

                var response = await client.GetAsync(Constants.SchemeCurrentUri);
                var content = await response.Content.ReadAsStringAsync();

                return await this.ParsePowerSchemeFromJSONAsync(content);
            }
        }

        public async Task<PowerScheme> ParsePowerSchemeFromJSONAsync(string contents)
        {
            PowerScheme scheme = new PowerScheme();
            JObject root = JObject.Parse(contents);

            return await Task.Run(() =>
            {
                Parallel.ForEach(
                    root["Groups"],
                    group =>
                    {
                        scheme.SubGroups.Add(this.ParseSubGroup(group));
                    });

                return scheme;
            });
        }

        private SubGroup ParseSubGroup(JToken group)
        {
            SubGroup newGroup = new SubGroup();

            foreach (JProperty token in group.Children<JProperty>())
            {
                switch (token.Name)
                {
                    case "GUID":
                        newGroup.GUID = (Guid)token.Value;
                        break;
                    case "Hidden":
                        newGroup.IsHidden = (bool)token.Value;
                        break;
                    case "FriendlyName":
                        newGroup.FriendlyName = (string)token.Value;
                        break;
                    case "Alias":
                        newGroup.Alias = (string)token.Value;
                        break;
                    case "Settings":
                        if (token.Value.Type == JTokenType.Array)
                        {
                            this.ParseSettings(newGroup.Settings, token.Value);
                        }
                        break;
                    default:
                        if (token.Value.Type == JTokenType.Object)
                        {
                            continue;
                        }
                        break;
            }
        }

            return newGroup;
        }

        private void ParseSettings(ConcurrentBag<Setting> settings, JToken value)
        {
            foreach (var setting in value.Children())
            {
                Setting newSetting = new Setting();

                foreach (JProperty settingValue in setting.Children())
                {
                    switch (settingValue.Name)
                    {
                        case "Units":
                            newSetting.Units = (string)settingValue.Value;
                            break;
                        case "Min":
                            newSetting.Min = (long)settingValue.Value;
                            break;
                        case "Max":
                            newSetting.Max = (long)settingValue.Value;
                            break;
                        case "Increment":
                            newSetting.Increment = (int)settingValue.Value;
                            break;
                        case "ValueAC":
                            newSetting.ValueAC = (long)settingValue.Value;
                            break;
                        case "ValueDC":
                            newSetting.ValueDC = (long)settingValue.Value;
                            break;
                        case "GUID":
                            newSetting.GUID = (Guid)settingValue.Value;
                            break;
                        case "Hidden":
                            newSetting.IsHidden = (bool)settingValue.Value;
                            break;
                        case "FriendlyName":
                            newSetting.FriendlyName = (string)settingValue.Value;
                            break;
                        case "Alias":
                            newSetting.Alias = (string)settingValue.Value;
                            break;
                        case "Possible": // Never seen this filled out...
                            break;
                        default:
                            break;
                    }
                }

                settings.Add(newSetting);
            }
        }
    }
}
