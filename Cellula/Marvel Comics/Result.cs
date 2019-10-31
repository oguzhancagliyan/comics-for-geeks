using System.Text.Json.Serialization;

namespace Cellula.Comics
{
    public class Result
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("modified")]
        public string Modified { get; set; }

        [JsonPropertyName("resourceURI")]
        public string ResourceUri { get; set; }

        [JsonPropertyName("urls")]
        public Url[] Urls { get; set; }

        [JsonPropertyName("thumbnail")]
        public Thumbnail Thumbnail { get; set; }

        [JsonPropertyName("comics")]
        public Comics Comics { get; set; }

        [JsonPropertyName("stories")]
        public Stories Stories { get; set; }

        [JsonPropertyName("events")]
        public Comics Events { get; set; }

        [JsonPropertyName("series")]
        public Comics Series { get; set; }
    }
}
