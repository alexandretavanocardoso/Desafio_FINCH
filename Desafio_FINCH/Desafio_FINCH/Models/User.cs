using System.ComponentModel.DataAnnotations;

namespace Desafio_FINCH.Models
{
    public class User
    {
        [Required(ErrorMessage = "E-mail é obrigatório!")]
        [Display(Name = "Digite seu e-mail")]
        [EmailAddress(ErrorMessage = "Digite um e-mail válido!")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatória!")]
        [Display(Name = "Digite sua senha")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }
    }
}
