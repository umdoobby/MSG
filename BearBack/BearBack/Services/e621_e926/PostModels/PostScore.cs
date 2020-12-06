using System.Text.Json.Serialization;

namespace BearBack.Services.e621_e926
{
    public class PostScore
    {
        [JsonPropertyName("up")]
        public int Up { get; set; }

        [JsonPropertyName("down")]
        public int Down { get; set; }

        [JsonPropertyName("total")]
        public int Total { get; set; }
    }
}