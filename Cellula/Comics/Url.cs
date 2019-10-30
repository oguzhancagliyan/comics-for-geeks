using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Cellula.Comics
{
    public class Url
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("url")]
        public string UrlUrl { get; set; }
    }
}
