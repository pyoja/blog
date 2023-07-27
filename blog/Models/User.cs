// blog/Models/User.cs

using System;
using System.ComponentModel.DataAnnotations;

namespace blog.Models
{
    public class User
    {
        [Key]
        public int No { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }
        public DateTime Reg_date { get; set; }
        public int Del_state { get; set; }
    }
}
