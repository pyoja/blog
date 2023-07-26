using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blog.Models
{
    public class Post
    {
        public int No { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImgUrl { get; set; }
        public int Like { get; set; }
        public string Comment { get; set; }
        public DateTime RegDate { get; set; }
        public byte DelState { get; set; }
    }
}