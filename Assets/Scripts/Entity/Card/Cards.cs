﻿using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Entity.Card
{
    // Generated by https://quicktype.io

    public partial class Cards
    {
        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("CardArray")]
        public CardArray[] CardArray { get; set; }
    }

    public partial class CardArray
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("img")]
        public string Img { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("hp")]
        public long Hp { get; set; }

        [JsonProperty("mp")]
        public long Mp { get; set; }

        [JsonProperty("def")]
        public long Def { get; set; }

        [JsonProperty("mag")]
        public long Mag { get; set; }

        [JsonProperty("atk")]
        public long Atk { get; set; }

        [JsonProperty("ene")]
        public long Ene { get; set; }

        [JsonProperty("hpGrow")]
        public long HpGrow { get; set; }

        [JsonProperty("mpGrow")]
        public long MpGrow { get; set; }

        [JsonProperty("atkGrow")]
        public long AtkGrow { get; set; }

        [JsonProperty("eneGrow")]
        public long EneGrow { get; set; }

        [JsonProperty("skills")]
        public long[] Skills { get; set; }
    }

    public partial class Cards
    {
        public static Cards FromJson(string json) => JsonConvert.DeserializeObject<Cards>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Cards self) => JsonConvert.SerializeObject(self, Converter.Settings);
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
