﻿namespace Entity.Entity
{
// Generated by https://quicktype.io

    namespace LoginMsg
    {
        using System;
        using System.Collections.Generic;

        using System.Globalization;
        using Newtonsoft.Json;
        using Newtonsoft.Json.Converters;

        public partial class LoginMsg
        {
            [JsonProperty("username")]
            public string Username { get; set; }

            [JsonProperty("userpwd")]
            public string Userpwd { get; set; }
        }

        public partial class LoginMsg
        {
            public static LoginMsg FromJson(string json) => JsonConvert.DeserializeObject<LoginMsg>(json, Converter.Settings);
        }

        public static class Serialize
        {
            public static string ToJson(this LoginMsg self) => JsonConvert.SerializeObject(self, Converter.Settings);
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

}