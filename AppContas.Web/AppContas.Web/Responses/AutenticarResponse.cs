namespace AppContas.Web.Responses
{
    public class AutenticarResponse
    {
        public string? Mensagem { get; set; }
        public UsuarioResponse? Usuario { get; set; }
        public string? AccessToken { get; set; }
        public DateTime? DataExpiracao { get; set; }
    }
}
