﻿using System;

namespace CoreServices.ViewModel
{
    public class PostViewModel
    {
        public int PostId { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public string TagList { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        

    }
}
