using System.Text.Json.Serialization;

namespace Cellula.Comics
{
    public class Comics
    {
        [JsonPropertyName("available")]
        public string Available { get; set; }

        [JsonPropertyName("returned")]
        public string Returned { get; set; }

        [JsonPropertyName("collectionURI")]
        public string CollectionUri { get; set; }

        [JsonPropertyName("items")]
        public ComicsItem[] Items { get; set; }
    }
}
