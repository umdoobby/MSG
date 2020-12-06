using System.Text.Json.Serialization;

namespace BearBack.Services.e621_e926
{
    public class PostPreview
    {
        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}