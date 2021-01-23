using System.Text.Json.Serialization;

namespace MsgDesktop.Models.E621
{
    public class PostFile
    {
        [JsonPropertyName("width")]
        public int Width { get; set; }

        [JsonPropertyName("height")]
        public int Height { get; set; }

        [JsonPropertyName("ext")]
        public string Extension { get; set; }

        [JsonPropertyName("size")]
        public long Size { get; set; }

        [JsonPropertyName("md5")]
        public string Md5 { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}