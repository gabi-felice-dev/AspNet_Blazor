using System.ComponentModel.DataAnnotations;

namespace AppContas.Web.Requests
{
    public class AutenticarRequest
    {
        [EmailAddress(ErrorMessage = "Por favor, informe um e-mail válido.")]
        [Required(ErrorMessage = "Por favor, informe seu e-mail.")]
        public string? Email { get; set; }

        [MinLength(8, ErrorMessage ="Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(20, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe sua senha.")]
        public string? Senha { get; set; }
    }
}
