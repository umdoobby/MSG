using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BearBack.Services.e621_e926
{
    public class PostSample
    {
        [JsonPropertyName("has")]
        public bool Has { get; set; }
        
        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("alternates")]
        public List<Dictionary<string,PostAlternates>> Type { get; set; }
    }
}