using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Cellula.Comics
{
    public class StoriesItem
    {
        [JsonPropertyName("resourceURI")]
        public string ResourceUri { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
