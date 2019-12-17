using System.ComponentModel.DataAnnotations;

namespace Ecommerce.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "E-mail")]
        [EmailAddress]
        public string UserName { get; set; }
        
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirmar Senha")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage="As senhas são diferentes")]
        public string ConfirmPassword { get; set; }

        public string ReturnUrl { get; set; }
    }
}