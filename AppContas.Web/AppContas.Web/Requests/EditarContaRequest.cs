using System.ComponentModel.DataAnnotations;

namespace AppContas.Web.Requests
{
    public class EditarContaRequest
    {
        public string? Id { get; set; }

        [MinLength(8, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome da conta.")]
        public string? NomeConta { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data da conta.")]
        public string? DataConta { get; set; }

        [Required(ErrorMessage = "Por favor, informe o valor da conta.")]
        public string? Valor { get; set; }

        [MinLength(8, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(250, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe as observações da conta.")]
        public string? Observacoes { get; set; }

        [Required(ErrorMessage = "Por favor, informe o tipo da conta.")]
        public string? TipoId { get; set; }

        [Required(ErrorMessage = "Por favor, informe a categoria da conta.")]
        public string? CategoriaId { get; set; }
    }
}
