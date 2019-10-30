using System.Text.Json.Serialization;

namespace Cellula.Comics
{
    public  class MarvelResponse
    {

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("copyright")]
        public string Copyright { get; set; }

        [JsonPropertyName("attributionText")]
        public string AttributionText { get; set; }

        [JsonPropertyName("attributionHTML")]
        public string AttributionHtml { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }

        [JsonPropertyName("etag")]
        public string Etag { get; set; }
    }
}
