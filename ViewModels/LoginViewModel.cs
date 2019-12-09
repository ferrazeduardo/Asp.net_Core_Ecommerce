using System.ComponentModel.DataAnnotations;

namespace Ecommerce.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "User name")]
        [RegularExpression(@"b[A-Z0-9._%-]+@[A-Z0-9.-]+.[A-Z]{2,4}b", ErrorMessage = "E-mail em formato inválido.")]
        public string UserName { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Display(Name = "Confirmar Senha")]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage="As senhas são diferentes")]
        public string ConfirmPassword { get; set; }

        public string ReturnUrl { get; set; }
    }
}