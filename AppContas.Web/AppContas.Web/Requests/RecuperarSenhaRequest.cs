using System.ComponentModel.DataAnnotations;

namespace AppContas.Web.Requests
{
    public class RecuperarSenhaRequest
    {
        [EmailAddress(ErrorMessage = "Por favor, informe um email válido.")]
        [Required(ErrorMessage = "Por favor, informe seu email.")]
        public string? Email { get; set; }
    }
}
