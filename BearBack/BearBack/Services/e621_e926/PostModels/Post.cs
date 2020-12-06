using System;
using System.Text.Json.Serialization;

namespace BearBack.Services.e621_e926
{
    public class Post
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("uploaded_at")]
        public DateTime UploadedAt { get; set; }

        [JsonPropertyName("file")]
        public PostFile File { get; set; }

        [JsonPropertyName("preview")]
        public PostPreview Preview { get; set; }

        [JsonPropertyName("sample")]
        public PostSample Sample { get; set; }

        [JsonPropertyName("score")]
        public PostScore Score { get; set; }

        [JsonPropertyName("tags")]
        public PostTags Tags { get; set; }

        [JsonPropertyName("locked_tags")]
        public string[] LockedTags { get; set; }

        [JsonPropertyName("change_seq")]
        public long ChangeSeq { get; set; }

        [JsonPropertyName("flags")]
        public PostFlags Flags { get; set; }

        [JsonPropertyName("rating")]
        public string Rating { get; set; }

        [JsonPropertyName("fav_count")]
        public int FavCount { get; set; }
        
        [JsonPropertyName("sources")] 
        public string[] Sources { get; set; }

        [JsonPropertyName("pools")]
        public long[] Pools { get; set; }

        [JsonPropertyName("relationships")]
        public PostRelationships Relationships { get; set; }

        [JsonPropertyName("approver_id")]
        public long ApproverId { get; set; }

        [JsonPropertyName("UploaderId")]
        public long UploaderId { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("comment_count")]
        public int CommentCount { get; set; }

        [JsonPropertyName("is_favorited")]
        public bool IsFavorited { get; set; }

        [JsonPropertyName("has_notes")]
        public bool HasNotes { get; set; }

        [JsonPropertyName("duration")]
        public double Duration { get; set; }
    }
}