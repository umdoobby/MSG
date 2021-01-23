using System.Text.Json.Serialization;

namespace MsgDesktop.Models.E621
{
    public class PostAlternates
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("urls")]
        public string[] Urls { get; set; }
    }
}