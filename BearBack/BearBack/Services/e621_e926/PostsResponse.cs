using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BearBack.Services.e621_e926
{
    public class PostsResponse
    {
        [JsonPropertyName("posts")]
        public List<Post> Posts { get; set; }
    }
}