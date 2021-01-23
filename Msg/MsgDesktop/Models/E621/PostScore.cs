using System.Text.Json.Serialization;

namespace MsgDesktop.Models.E621
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