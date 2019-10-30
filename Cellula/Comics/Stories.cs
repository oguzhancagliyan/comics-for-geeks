using System.Text.Json.Serialization;

namespace Cellula.Comics
{
    public  class Stories
    {
        [JsonPropertyName("available")]
        public string Available { get; set; }

        [JsonPropertyName("returned")]
        public string Returned { get; set; }

        [JsonPropertyName("collectionURI")]
        public string CollectionUri { get; set; }

        [JsonPropertyName("items")]
        public StoriesItem[] Items { get; set; }
    }
}
