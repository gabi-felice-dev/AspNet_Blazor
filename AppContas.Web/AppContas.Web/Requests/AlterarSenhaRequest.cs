using System.ComponentModel.DataAnnotations;

namespace AppContas.Web.Requests
{
    public class AlterarSenhaRequest
    {
        [MinLength(8, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(20, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a senha atual.")]
        public string? SenhaAtual { get; set; }

        [MinLength(8, ErrorMessage = "Por favor, informe no mínimo {1} caracteres.")]
        [MaxLength(20, ErrorMessage = "Por favor, informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a nova senha.")]
        public string? NovaSenha { get; set; }

        [Compare("NovaSenha", ErrorMessage = "Senhas não conferem")]
        [Required(ErrorMessage = "Por favor, confirme a nova senha.")]
        public string? NovaSenhaConfirmacao { get; set; }
    }
}
