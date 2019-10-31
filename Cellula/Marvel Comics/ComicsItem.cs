using System.Text.Json.Serialization;

namespace Cellula.Comics
{
    public class ComicsItem
    {
        [JsonPropertyName("resourceURI")]
        public string ResourceUri { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
