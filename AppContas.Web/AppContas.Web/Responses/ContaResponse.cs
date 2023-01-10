namespace AppContas.Web.Responses
{
    public class ContaResponse
    {
        public Guid? Id { get; set; }
        public string? NomeConta { get; set; }
        public DateTime? DataConta { get; set; }
        public decimal? Valor { get; set; }
        public string? Observacoes { get; set; }
        public Tipo? Tipo { get; set; }
        public Categoria? Categoria { get; set; }
    }

    public class Tipo
    {
        public int? Id { get; set; }
        public string? Nome { get; set; }
    }

    public class Categoria
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
    }
}
