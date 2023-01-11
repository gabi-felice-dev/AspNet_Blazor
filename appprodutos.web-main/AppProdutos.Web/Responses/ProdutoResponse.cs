namespace AppProdutos.Web.Responses
{
    /// <summary>
    /// Modelo de dados do produto retornado pela API
    /// </summary>
    public class ProdutoResponse
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Foto { get; set; }
    }

}
