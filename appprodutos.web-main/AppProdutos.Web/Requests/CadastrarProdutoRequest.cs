using System.ComponentModel.DataAnnotations;

namespace AppProdutos.Web.Requests
{
    /// <summary>
    /// Modelo de dados para o formulário de cadastro de produtos
    /// </summary>
    public class CadastrarProdutoRequest
    {
        [MinLength(8, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe o nome do produto.")]
        public string? Nome { get; set; }

        [MinLength(8, ErrorMessage = "Informe no mínimo {1} caracteres.")]
        [MaxLength(250, ErrorMessage = "Informe no máximo {1} caracteres.")]
        [Required(ErrorMessage = "Por favor, informe a descrição do produto.")]
        public string? Descricao { get; set; }
    }
}
