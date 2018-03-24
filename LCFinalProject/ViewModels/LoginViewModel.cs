using LCFinalProject.Models;
using System.ComponentModel.DataAnnotations;

namespace LCFinalProject.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "You must provide a username")]
        [Display(Name = "Username")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public User User { get; set; }


        public LoginViewModel() { }



    }
}
