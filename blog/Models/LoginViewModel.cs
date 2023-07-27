using System.ComponentModel.DataAnnotations;

namespace blog.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "ID")]
        public string Id { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}
