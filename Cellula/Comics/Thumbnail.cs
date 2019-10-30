using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Cellula.Comics
{
    public class Thumbnail
    {
        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("extension")]
        public string Extension { get; set; }
    }
}
