using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Cellula.Comics
{
    public class Data
    {
        [JsonPropertyName("offset")]
        public string Offset { get; set; }

        [JsonPropertyName("limit")]
        public string Limit { get; set; }

        [JsonPropertyName("total")]
        public string Total { get; set; }

        [JsonPropertyName("count")]
        public string Count { get; set; }

        [JsonPropertyName("results")]
        public List<Result> Results { get; set; }
    }
}
