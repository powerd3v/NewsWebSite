using System.ComponentModel.DataAnnotations;

namespace NewsWebSite.Models
{
    public class RegisterModel : LoginModel
    {

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; } = "";
        [Required]
        public string Role { get; set; } = "";
    }
}
