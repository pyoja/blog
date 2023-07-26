using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace blog.Models
{
    public class User
    {
        public int No { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public DateTime RegDate { get; set; }
        public byte DelState { get; set; }
    }

}