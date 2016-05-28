using System.Collections.Generic;

namespace HoloLens.Hardware.Api.Power.Config
{

    public class BATACTIONCRIT
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class BATACTIONLOW
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class BATFLAGSLOW
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class BATLEVELCRIT
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class BATLEVELLOW
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class Setting
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
        public int? Increment { get; set; }
        public int? Max { get; set; }
        public int? Min { get; set; }
        public string Units { get; set; }
    }

    public class SUBBATTERY
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public BATACTIONCRIT BATACTIONCRIT { get; set; }
        public BATACTIONLOW BATACTIONLOW { get; set; }
        public BATFLAGSLOW BATFLAGSLOW { get; set; }
        public BATLEVELCRIT BATLEVELCRIT { get; set; }
        public BATLEVELLOW BATLEVELLOW { get; set; }
        public List<Setting> Settings { get; set; }
    }

    public class LIDACTION
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PBUTTONACTION
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class SBUTTONACTION
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class SHUTDOWN
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class UIBUTTONACTION
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class Setting2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class SUBBUTTONS
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public LIDACTION LIDACTION { get; set; }
        public PBUTTONACTION PBUTTONACTION { get; set; }
        public SBUTTONACTION SBUTTONACTION { get; set; }
        public SHUTDOWN SHUTDOWN { get; set; }
        public UIBUTTONACTION UIBUTTON_ACTION { get; set; }
        public List<Setting2> Settings { get; set; }
    }

    public class DISKBURSTIGNORE
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class DISKIDLE
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class DISKMAXPOWER
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class Setting3
    {
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
        public string Alias { get; set; }
        public int? Increment { get; set; }
        public long? Max { get; set; }
        public int? Min { get; set; }
        public string Units { get; set; }
    }

    public class SUBDISK
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public DISKBURSTIGNORE DISKBURSTIGNORE { get; set; }
        public DISKIDLE DISKIDLE { get; set; }
        public DISKMAXPOWER DISKMAXPOWER { get; set; }
        public List<Setting3> Settings { get; set; }
    }

    public class ESBATTTHRESHOLD
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class ESBRIGHTNESS
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class Setting4
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class SUBENERGYSAVER
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public ESBATTTHRESHOLD ESBATTTHRESHOLD { get; set; }
        public ESBRIGHTNESS ESBRIGHTNESS { get; set; }
        public List<Setting4> Settings { get; set; }
    }

    public class MODE
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERPROCLOAD
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class UNPARKTIME
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class Setting5
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
        public int? Increment { get; set; }
        public int? Max { get; set; }
        public int? Min { get; set; }
        public string Units { get; set; }
    }

    public class SUBINTSTEER
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public MODE MODE { get; set; }
        public PERPROCLOAD PERPROCLOAD { get; set; }
        public UNPARKTIME UNPARKTIME { get; set; }
        public List<Setting5> Settings { get; set; }
    }

    public class COALTIME
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class DEEPSLEEP
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class EXECTIME
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public long ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PROCIR
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class Setting6
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public object Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public long ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class SUBIR
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public COALTIME COALTIME { get; set; }
        public DEEPSLEEP DEEPSLEEP { get; set; }
        public EXECTIME EXECTIME { get; set; }
        public PROCIR PROCIR { get; set; }
        public List<Setting6> Settings { get; set; }
    }

    public class CONSOLELOCK
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class DEVICEIDLE
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERSONALITY
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class WIFIINSTANDBY
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class Setting7
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class SUBNONE
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public CONSOLELOCK CONSOLELOCK { get; set; }
        public DEVICEIDLE DEVICEIDLE { get; set; }
        public PERSONALITY PERSONALITY { get; set; }
        public WIFIINSTANDBY WIFIINSTANDBY { get; set; }
        public List<Setting7> Settings { get; set; }
    }

    public class ASPM
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class Setting8
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class SUBPCIEXPRESS
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public ASPM ASPM { get; set; }
        public List<Setting8> Settings { get; set; }
    }

    public class NSENINPUTPRETIME
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class USERPRESENCEPREDICTION
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class Setting9
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class SUBPRESENCE
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public NSENINPUTPRETIME NSENINPUTPRETIME { get; set; }
        public USERPRESENCEPREDICTION USERPRESENCEPREDICTION { get; set; }
        public List<Setting9> Settings { get; set; }
    }

    public class CPCONCURRENCY
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPDECREASEPOL
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class CPDECREASETIME
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPDISTRIBUTION
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPHEADROOM
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPINCREASEPOL
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class CPINCREASETIME
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPMAXCORES
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPMAXCORES1
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPMINCORES
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPMINCORES1
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPOVERUTIL
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPPERF
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class CPPERF1
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class DISTRIBUTEUTIL
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class HETEROCLASS0FLOORPERF
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class HETEROCLASS1INITIALPERF
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class HETERODECREASETHRESHOLD
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class HETERODECREASETIME
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class HETEROINCREASETHRESHOLD
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class HETEROINCREASETIME
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class HETEROPOLICY
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class IDLECHECK
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class IDLEDEMOTE
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class IDLEDISABLE
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class IDLEPROMOTE
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class IDLESCALING
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class IDLESTATEMAX
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class LATENCYHINTPERF
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class LATENCYHINTPERF1
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class LATENCYHINTUNPARK
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class LATENCYHINTUNPARK1
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFAUTONOMOUS
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERFAUTONOMOUSWINDOW
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFBOOSTMODE
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERFBOOSTPOL
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFCHECK
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFDECPOL
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERFDECPOL1
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERFDECTHRESHOLD
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFDECTHRESHOLD1
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFDECTIME
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFDECTIME1
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFDUTYCYCLING
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERFEPP
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFHISTORY
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFHISTORY1
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFINCPOL
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERFINCPOL1
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERFINCTHRESHOLD
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFINCTHRESHOLD1
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFINCTIME
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFINCTIME1
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PROCTHROTTLEMAX
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PROCTHROTTLEMAX1
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PROCTHROTTLEMIN
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PROCTHROTTLEMIN1
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class SYSCOOLPOL
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class THROTTLING
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class Setting10
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class SUBPROCESSOR
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public CPCONCURRENCY CPCONCURRENCY { get; set; }
        public CPDECREASEPOL CPDECREASEPOL { get; set; }
        public CPDECREASETIME CPDECREASETIME { get; set; }
        public CPDISTRIBUTION CPDISTRIBUTION { get; set; }
        public CPHEADROOM CPHEADROOM { get; set; }
        public CPINCREASEPOL CPINCREASEPOL { get; set; }
        public CPINCREASETIME CPINCREASETIME { get; set; }
        public CPMAXCORES CPMAXCORES { get; set; }
        public CPMAXCORES1 CPMAXCORES1 { get; set; }
        public CPMINCORES CPMINCORES { get; set; }
        public CPMINCORES1 CPMINCORES1 { get; set; }
        public CPOVERUTIL CPOVERUTIL { get; set; }
        public CPPERF CPPERF { get; set; }
        public CPPERF1 CPPERF1 { get; set; }
        public DISTRIBUTEUTIL DISTRIBUTEUTIL { get; set; }
        public HETEROCLASS0FLOORPERF HETEROCLASS0FLOORPERF { get; set; }
        public HETEROCLASS1INITIALPERF HETEROCLASS1INITIALPERF { get; set; }
        public HETERODECREASETHRESHOLD HETERODECREASETHRESHOLD { get; set; }
        public HETERODECREASETIME HETERODECREASETIME { get; set; }
        public HETEROINCREASETHRESHOLD HETEROINCREASETHRESHOLD { get; set; }
        public HETEROINCREASETIME HETEROINCREASETIME { get; set; }
        public HETEROPOLICY HETEROPOLICY { get; set; }
        public IDLECHECK IDLECHECK { get; set; }
        public IDLEDEMOTE IDLEDEMOTE { get; set; }
        public IDLEDISABLE IDLEDISABLE { get; set; }
        public IDLEPROMOTE IDLEPROMOTE { get; set; }
        public IDLESCALING IDLESCALING { get; set; }
        public IDLESTATEMAX IDLESTATEMAX { get; set; }
        public LATENCYHINTPERF LATENCYHINTPERF { get; set; }
        public LATENCYHINTPERF1 LATENCYHINTPERF1 { get; set; }
        public LATENCYHINTUNPARK LATENCYHINTUNPARK { get; set; }
        public LATENCYHINTUNPARK1 LATENCYHINTUNPARK1 { get; set; }
        public PERFAUTONOMOUS PERFAUTONOMOUS { get; set; }
        public PERFAUTONOMOUSWINDOW PERFAUTONOMOUSWINDOW { get; set; }
        public PERFBOOSTMODE PERFBOOSTMODE { get; set; }
        public PERFBOOSTPOL PERFBOOSTPOL { get; set; }
        public PERFCHECK PERFCHECK { get; set; }
        public PERFDECPOL PERFDECPOL { get; set; }
        public PERFDECPOL1 PERFDECPOL1 { get; set; }
        public PERFDECTHRESHOLD PERFDECTHRESHOLD { get; set; }
        public PERFDECTHRESHOLD1 PERFDECTHRESHOLD1 { get; set; }
        public PERFDECTIME PERFDECTIME { get; set; }
        public PERFDECTIME1 PERFDECTIME1 { get; set; }
        public PERFDUTYCYCLING PERFDUTYCYCLING { get; set; }
        public PERFEPP PERFEPP { get; set; }
        public PERFHISTORY PERFHISTORY { get; set; }
        public PERFHISTORY1 PERFHISTORY1 { get; set; }
        public PERFINCPOL PERFINCPOL { get; set; }
        public PERFINCPOL1 PERFINCPOL1 { get; set; }
        public PERFINCTHRESHOLD PERFINCTHRESHOLD { get; set; }
        public PERFINCTHRESHOLD1 PERFINCTHRESHOLD1 { get; set; }
        public PERFINCTIME PERFINCTIME { get; set; }
        public PERFINCTIME1 PERFINCTIME1 { get; set; }
        public PROCTHROTTLEMAX PROCTHROTTLEMAX { get; set; }
        public PROCTHROTTLEMAX1 PROCTHROTTLEMAX1 { get; set; }
        public PROCTHROTTLEMIN PROCTHROTTLEMIN { get; set; }
        public PROCTHROTTLEMIN1 PROCTHROTTLEMIN1 { get; set; }
        public SYSCOOLPOL SYSCOOLPOL { get; set; }
        public THROTTLING THROTTLING { get; set; }
        public List<Setting10> Settings { get; set; }
    }

    public class ALLOWSTANDBY
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class AWAYMODE
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class HIBERNATEIDLE
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class HYBRIDSLEEP
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class RTCWAKE
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class STANDBYIDLE
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class SYSTEMREQUIRED
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class UNATTENDSLEEP
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class Setting11
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
        public int? Increment { get; set; }
        public long? Max { get; set; }
        public int? Min { get; set; }
        public string Units { get; set; }
    }

    public class SUBSLEEP
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public ALLOWSTANDBY ALLOWSTANDBY { get; set; }
        public AWAYMODE AWAYMODE { get; set; }
        public HIBERNATEIDLE HIBERNATEIDLE { get; set; }
        public HYBRIDSLEEP HYBRIDSLEEP { get; set; }
        public RTCWAKE RTCWAKE { get; set; }
        public STANDBYIDLE STANDBYIDLE { get; set; }
        public SYSTEMREQUIRED SYSTEMREQUIRED { get; set; }
        public UNATTENDSLEEP UNATTENDSLEEP { get; set; }
        public List<Setting11> Settings { get; set; }
    }

    public class ADAPTBRIGHT
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class ALLOWDISPLAY
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class VIDEOADAPT
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class VIDEOADAPTINC
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class VIDEOANNOY
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class VIDEOCONLOCK
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class VIDEODIM
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class VIDEOIDLE
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class Setting12
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public object Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class SUBVIDEO
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public ADAPTBRIGHT ADAPTBRIGHT { get; set; }
        public ALLOWDISPLAY ALLOWDISPLAY { get; set; }
        public VIDEOADAPT VIDEOADAPT { get; set; }
        public VIDEOADAPTINC VIDEOADAPTINC { get; set; }
        public VIDEOANNOY VIDEOANNOY { get; set; }
        public VIDEOCONLOCK VIDEOCONLOCK { get; set; }
        public VIDEODIM VIDEODIM { get; set; }
        public VIDEOIDLE VIDEOIDLE { get; set; }
        public List<Setting12> Settings { get; set; }
    }

    public class CONSOLELOCK2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class DEVICEIDLE2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERSONALITY2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class WIFIINSTANDBY2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class Setting13
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public long ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
        public int? Increment { get; set; }
        public long? Max { get; set; }
        public int? Min { get; set; }
        public string Units { get; set; }
    }

    public class DISKBURSTIGNORE2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class DISKIDLE2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class DISKMAXPOWER2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class ALLOWSTANDBY2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class AWAYMODE2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class HIBERNATEIDLE2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class HYBRIDSLEEP2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class RTCWAKE2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class STANDBYIDLE2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class SYSTEMREQUIRED2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class UNATTENDSLEEP2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class COALTIME2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class DEEPSLEEP2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class EXECTIME2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public long ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PROCIR2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class MODE2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERPROCLOAD2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class UNPARKTIME2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class LIDACTION2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PBUTTONACTION2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class SBUTTONACTION2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class SHUTDOWN2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class UIBUTTONACTION2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class ASPM2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class CPCONCURRENCY2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPDECREASEPOL2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class CPDECREASETIME2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPDISTRIBUTION2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPHEADROOM2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPINCREASEPOL2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class CPINCREASETIME2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPMAXCORES2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPMAXCORES12
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPMINCORES2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPMINCORES12
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPOVERUTIL2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class CPPERF2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class CPPERF12
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class DISTRIBUTEUTIL2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class HETEROCLASS0FLOORPERF2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class HETEROCLASS1INITIALPERF2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class HETERODECREASETHRESHOLD2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class HETERODECREASETIME2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class HETEROINCREASETHRESHOLD2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class HETEROINCREASETIME2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class HETEROPOLICY2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class IDLECHECK2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class IDLEDEMOTE2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class IDLEDISABLE2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class IDLEPROMOTE2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class IDLESCALING2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class IDLESTATEMAX2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class LATENCYHINTPERF2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class LATENCYHINTPERF12
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class LATENCYHINTUNPARK2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class LATENCYHINTUNPARK12
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFAUTONOMOUS2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERFAUTONOMOUSWINDOW2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFBOOSTMODE2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERFBOOSTPOL2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFCHECK2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFDECPOL2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERFDECPOL12
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERFDECTHRESHOLD2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFDECTHRESHOLD12
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFDECTIME2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFDECTIME12
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFDUTYCYCLING2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERFEPP2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFHISTORY2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFHISTORY12
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFINCPOL2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERFINCPOL12
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class PERFINCTHRESHOLD2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFINCTHRESHOLD12
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFINCTIME2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PERFINCTIME12
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PROCTHROTTLEMAX2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PROCTHROTTLEMAX12
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PROCTHROTTLEMIN2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class PROCTHROTTLEMIN12
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class SYSCOOLPOL2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class THROTTLING2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class ADAPTBRIGHT2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class ALLOWDISPLAY2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class VIDEOADAPT2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class VIDEOADAPTINC2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class VIDEOANNOY2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class VIDEOCONLOCK2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class VIDEODIM2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class VIDEOIDLE2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class NSENINPUTPRETIME2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public long Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class USERPRESENCEPREDICTION2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class ESBATTTHRESHOLD2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class ESBRIGHTNESS2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class BATACTIONCRIT2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class BATACTIONLOW2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class BATFLAGSLOW2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
        public List<object> Possible { get; set; }
    }

    public class BATLEVELCRIT2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class BATLEVELLOW2
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public int Increment { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Units { get; set; }
        public int ValueAC { get; set; }
        public int ValueDC { get; set; }
    }

    public class Group
    {
        public string Alias { get; set; }
        public string FriendlyName { get; set; }
        public string GUID { get; set; }
        public string Hidden { get; set; }
        public CONSOLELOCK2 CONSOLELOCK { get; set; }
        public DEVICEIDLE2 DEVICEIDLE { get; set; }
        public PERSONALITY2 PERSONALITY { get; set; }
        public WIFIINSTANDBY2 WIFIINSTANDBY { get; set; }
        public List<Setting13> Settings { get; set; }
        public DISKBURSTIGNORE2 DISKBURSTIGNORE { get; set; }
        public DISKIDLE2 DISKIDLE { get; set; }
        public DISKMAXPOWER2 DISKMAXPOWER { get; set; }
        public ALLOWSTANDBY2 ALLOWSTANDBY { get; set; }
        public AWAYMODE2 AWAYMODE { get; set; }
        public HIBERNATEIDLE2 HIBERNATEIDLE { get; set; }
        public HYBRIDSLEEP2 HYBRIDSLEEP { get; set; }
        public RTCWAKE2 RTCWAKE { get; set; }
        public STANDBYIDLE2 STANDBYIDLE { get; set; }
        public SYSTEMREQUIRED2 SYSTEMREQUIRED { get; set; }
        public UNATTENDSLEEP2 UNATTENDSLEEP { get; set; }
        public COALTIME2 COALTIME { get; set; }
        public DEEPSLEEP2 DEEPSLEEP { get; set; }
        public EXECTIME2 EXECTIME { get; set; }
        public PROCIR2 PROCIR { get; set; }
        public MODE2 MODE { get; set; }
        public PERPROCLOAD2 PERPROCLOAD { get; set; }
        public UNPARKTIME2 UNPARKTIME { get; set; }
        public LIDACTION2 LIDACTION { get; set; }
        public PBUTTONACTION2 PBUTTONACTION { get; set; }
        public SBUTTONACTION2 SBUTTONACTION { get; set; }
        public SHUTDOWN2 SHUTDOWN { get; set; }
        public UIBUTTONACTION2 UIBUTTON_ACTION { get; set; }
        public ASPM2 ASPM { get; set; }
        public CPCONCURRENCY2 CPCONCURRENCY { get; set; }
        public CPDECREASEPOL2 CPDECREASEPOL { get; set; }
        public CPDECREASETIME2 CPDECREASETIME { get; set; }
        public CPDISTRIBUTION2 CPDISTRIBUTION { get; set; }
        public CPHEADROOM2 CPHEADROOM { get; set; }
        public CPINCREASEPOL2 CPINCREASEPOL { get; set; }
        public CPINCREASETIME2 CPINCREASETIME { get; set; }
        public CPMAXCORES2 CPMAXCORES { get; set; }
        public CPMAXCORES12 CPMAXCORES1 { get; set; }
        public CPMINCORES2 CPMINCORES { get; set; }
        public CPMINCORES12 CPMINCORES1 { get; set; }
        public CPOVERUTIL2 CPOVERUTIL { get; set; }
        public CPPERF2 CPPERF { get; set; }
        public CPPERF12 CPPERF1 { get; set; }
        public DISTRIBUTEUTIL2 DISTRIBUTEUTIL { get; set; }
        public HETEROCLASS0FLOORPERF2 HETEROCLASS0FLOORPERF { get; set; }
        public HETEROCLASS1INITIALPERF2 HETEROCLASS1INITIALPERF { get; set; }
        public HETERODECREASETHRESHOLD2 HETERODECREASETHRESHOLD { get; set; }
        public HETERODECREASETIME2 HETERODECREASETIME { get; set; }
        public HETEROINCREASETHRESHOLD2 HETEROINCREASETHRESHOLD { get; set; }
        public HETEROINCREASETIME2 HETEROINCREASETIME { get; set; }
        public HETEROPOLICY2 HETEROPOLICY { get; set; }
        public IDLECHECK2 IDLECHECK { get; set; }
        public IDLEDEMOTE2 IDLEDEMOTE { get; set; }
        public IDLEDISABLE2 IDLEDISABLE { get; set; }
        public IDLEPROMOTE2 IDLEPROMOTE { get; set; }
        public IDLESCALING2 IDLESCALING { get; set; }
        public IDLESTATEMAX2 IDLESTATEMAX { get; set; }
        public LATENCYHINTPERF2 LATENCYHINTPERF { get; set; }
        public LATENCYHINTPERF12 LATENCYHINTPERF1 { get; set; }
        public LATENCYHINTUNPARK2 LATENCYHINTUNPARK { get; set; }
        public LATENCYHINTUNPARK12 LATENCYHINTUNPARK1 { get; set; }
        public PERFAUTONOMOUS2 PERFAUTONOMOUS { get; set; }
        public PERFAUTONOMOUSWINDOW2 PERFAUTONOMOUSWINDOW { get; set; }
        public PERFBOOSTMODE2 PERFBOOSTMODE { get; set; }
        public PERFBOOSTPOL2 PERFBOOSTPOL { get; set; }
        public PERFCHECK2 PERFCHECK { get; set; }
        public PERFDECPOL2 PERFDECPOL { get; set; }
        public PERFDECPOL12 PERFDECPOL1 { get; set; }
        public PERFDECTHRESHOLD2 PERFDECTHRESHOLD { get; set; }
        public PERFDECTHRESHOLD12 PERFDECTHRESHOLD1 { get; set; }
        public PERFDECTIME2 PERFDECTIME { get; set; }
        public PERFDECTIME12 PERFDECTIME1 { get; set; }
        public PERFDUTYCYCLING2 PERFDUTYCYCLING { get; set; }
        public PERFEPP2 PERFEPP { get; set; }
        public PERFHISTORY2 PERFHISTORY { get; set; }
        public PERFHISTORY12 PERFHISTORY1 { get; set; }
        public PERFINCPOL2 PERFINCPOL { get; set; }
        public PERFINCPOL12 PERFINCPOL1 { get; set; }
        public PERFINCTHRESHOLD2 PERFINCTHRESHOLD { get; set; }
        public PERFINCTHRESHOLD12 PERFINCTHRESHOLD1 { get; set; }
        public PERFINCTIME2 PERFINCTIME { get; set; }
        public PERFINCTIME12 PERFINCTIME1 { get; set; }
        public PROCTHROTTLEMAX2 PROCTHROTTLEMAX { get; set; }
        public PROCTHROTTLEMAX12 PROCTHROTTLEMAX1 { get; set; }
        public PROCTHROTTLEMIN2 PROCTHROTTLEMIN { get; set; }
        public PROCTHROTTLEMIN12 PROCTHROTTLEMIN1 { get; set; }
        public SYSCOOLPOL2 SYSCOOLPOL { get; set; }
        public THROTTLING2 THROTTLING { get; set; }
        public ADAPTBRIGHT2 ADAPTBRIGHT { get; set; }
        public ALLOWDISPLAY2 ALLOWDISPLAY { get; set; }
        public VIDEOADAPT2 VIDEOADAPT { get; set; }
        public VIDEOADAPTINC2 VIDEOADAPTINC { get; set; }
        public VIDEOANNOY2 VIDEOANNOY { get; set; }
        public VIDEOCONLOCK2 VIDEOCONLOCK { get; set; }
        public VIDEODIM2 VIDEODIM { get; set; }
        public VIDEOIDLE2 VIDEOIDLE { get; set; }
        public NSENINPUTPRETIME2 NSENINPUTPRETIME { get; set; }
        public USERPRESENCEPREDICTION2 USERPRESENCEPREDICTION { get; set; }
        public ESBATTTHRESHOLD2 ESBATTTHRESHOLD { get; set; }
        public ESBRIGHTNESS2 ESBRIGHTNESS { get; set; }
        public BATACTIONCRIT2 BATACTIONCRIT { get; set; }
        public BATACTIONLOW2 BATACTIONLOW { get; set; }
        public BATFLAGSLOW2 BATFLAGSLOW { get; set; }
        public BATLEVELCRIT2 BATLEVELCRIT { get; set; }
        public BATLEVELLOW2 BATLEVELLOW { get; set; }
    }

    public class PowerScheme
    {
        public SUBBATTERY SUB_BATTERY { get; set; }
        public SUBBUTTONS SUB_BUTTONS { get; set; }
        public SUBDISK SUB_DISK { get; set; }
        public SUBENERGYSAVER SUB_ENERGYSAVER { get; set; }
        public SUBINTSTEER SUB_INTSTEER { get; set; }
        public SUBIR SUB_IR { get; set; }
        public SUBNONE SUB_NONE { get; set; }
        public SUBPCIEXPRESS SUB_PCIEXPRESS { get; set; }
        public SUBPRESENCE SUB_PRESENCE { get; set; }
        public SUBPROCESSOR SUB_PROCESSOR { get; set; }
        public SUBSLEEP SUB_SLEEP { get; set; }
        public SUBVIDEO SUB_VIDEO { get; set; }
        public List<Group> Groups { get; set; }
    }
}
