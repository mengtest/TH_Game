using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Entity.Config
{

    public partial class LocalConfig
    {
        [JsonProperty("application")]
        public string Application { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("configs")]
        public Configs Configs { get; set; }
    }

    public partial class Configs
    {
        [JsonProperty("bgmVol")]
        public long BgmVol { get; set; }

        [JsonProperty("chVol")]
        public long ChVol { get; set; }

        [JsonProperty("effVol")]
        public long EffVol { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public partial class LocalConfig
    {
        public static LocalConfig FromJson(string json) => JsonConvert.DeserializeObject<LocalConfig>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this LocalConfig self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}