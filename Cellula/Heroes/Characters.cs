using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Cellula.Heroes
{
    public class Characters
    {
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("description")]
        public string Description { get; set; }
        [JsonPropertyName("modified")]
        public DateTime Modified { get; set; }
        [JsonPropertyName("resourceURI")]
        public string ResourceUri { get; set; }
        [JsonPropertyName("urls")]
        public List<Uri> Urls { get; set; }
        [JsonPropertyName("thumbnail")]
        public Images Thumbnail { get; set; }

    }
    public class Images
    {
        [JsonPropertyName("path")]
        public string Path { get; set; }
        [JsonPropertyName("extension")]
        public string Extension { get; set; }
    }
}
