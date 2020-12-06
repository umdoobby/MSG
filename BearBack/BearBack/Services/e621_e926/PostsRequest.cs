using System;
using System.Collections.Generic;

namespace BearBack.Services.e621_e926
{
    public class PostsRequest
    {
        public int Limit { get; set; }

        public List<string> Tags { get; set; }

        public string Page { get; set; }

        public string UserName { get; set; }

        public string ApiKey { get; set; }
    }
}