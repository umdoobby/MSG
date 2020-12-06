using System.Text.Json.Serialization;

namespace BearBack.Services.e621_e926
{
    public class PostRelationships
    {
        [JsonPropertyName("parent_id")]
        public long ParentId { get; set; }

        [JsonPropertyName("has_children")]
        public bool HasChildren { get; set; }

        [JsonPropertyName("has_active_children")]
        public bool HasActiveChildren { get; set; }

        [JsonPropertyName("children")]
        public long[] Children { get; set; }
    }
}