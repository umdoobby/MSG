using System.Text.Json.Serialization;

namespace BearBack.Services.e621_e926
{
    public class PostTags
    {
        [JsonPropertyName("general")]
        public string[] General { get; set; }

        [JsonPropertyName("species")]
        public string[] Species { get; set; }

        [JsonPropertyName("character")]
        public string[] Character { get; set; }

        [JsonPropertyName("copyright")]
        public string[] Copyright { get; set; }

        [JsonPropertyName("artist")]
        public string[] Artist { get; set; }

        [JsonPropertyName("invalid")]
        public string[] Invalid { get; set; }

        [JsonPropertyName("lore")]
        public string[] Lore { get; set; }

        [JsonPropertyName("meta")]
        public string[] Meta { get; set; }
    }
}