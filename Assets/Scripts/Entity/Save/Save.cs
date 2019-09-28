using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Game.Entity.Save
{
    public partial class Save
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("initial")]
        public bool Initial { get; set; }
    }

    public partial class Save
    {
        public static Save FromJson(string json) => JsonConvert.DeserializeObject<Save>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Save self) => JsonConvert.SerializeObject(self, Converter.Settings);
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