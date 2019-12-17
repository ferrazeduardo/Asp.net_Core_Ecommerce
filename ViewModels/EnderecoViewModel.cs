using System.ComponentModel.DataAnnotations;

namespace Ecommerce.ViewModels
{
    public class EnderecoViewModel
    {
        [Required(ErrorMessage="O logradouro é obrigatorio")]
        [Display(Name="Logradouro")]
        [StringLength(100,MinimumLength=5,
        ErrorMessage="o logradouro deve ter no minimo 5 letras e no maximo 100")]
        public string Localizacao { get; set; }
        [Required(ErrorMessage="O numero da casa é obrigatirio")]
        [Display(Name="Numero")]
        [RegularExpression(@"^[0-9.]+$")]
        public int NumeroDaCasa { get; set; }
        [Required(ErrorMessage="Cidade é obrigatoria")]
        [Display(Name="Cidade")]
        [StringLength(10,
        ErrorMessage="cidade deve ter no maximo dez letras")]
        public string Cidade { get; set; }
        [Required(ErrorMessage="Estado é obrigatorio")]
        [Display(Name="Estado")]
        [StringLength(10,
        ErrorMessage="estado deve ter no maximo dez letras")]
        public string Estado { get; set; }
    }
}