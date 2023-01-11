namespace AppProdutos.Web.Responses
{
    /// <summary>
    /// Modelo de dados retornado pela API no cadastro do produto
    /// </summary>
    public class CadastrarProdutoResponse
    {
        public string? Mensagem { get; set; }
        public ProdutoResponse? Produto { get; set; }
    }
}
