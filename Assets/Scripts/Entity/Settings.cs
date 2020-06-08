// Generated by https://quicktype.io

namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Json
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("application")]
        public string Application { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("port")]
        public long Port { get; set; }

        [JsonProperty("configs")]
        public Configs Configs { get; set; }

        [JsonProperty("video_config")]
        public VideoConfig VideoConfig { get; set; }

        [JsonProperty("user_config")]
        public UserConfig UserConfig { get; set; }

        [JsonProperty("desc")]
        public string Desc { get; set; }
    }

    public partial class Configs
    {
        [JsonProperty("bgmVol")]
        public int BgmVol { get; set; }

        [JsonProperty("chVol")]
        public int ChVol { get; set; }

        [JsonProperty("effVol")]
        public int EffVol { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }
    }

    public partial class UserConfig
    {
        [JsonProperty("uid")]
        public long Uid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("last_login_time")]
        public string LastLoginTime { get; set; }
    }

    public partial class VideoConfig
    {
        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("full_screen")]
        public bool FullScreen { get; set; }

        [JsonProperty("no_boarder")]
        public bool NoBoarder { get; set; }
    }

    public partial class Json
    {
        public static Json FromJson(string json) => JsonConvert.DeserializeObject<Json>(json, QuickType.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Json self) => JsonConvert.SerializeObject(self, QuickType.Converter.Settings);
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