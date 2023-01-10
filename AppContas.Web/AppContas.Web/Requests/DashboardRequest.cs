using System.ComponentModel.DataAnnotations;

namespace AppContas.Web.Requests
{
    public class DashboardRequest
    {
        [Required(ErrorMessage = "Por favor, informe a data de início.")]
        public string? DataIni { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data de término.")]
        public string? DataFim { get; set; }

        [Required(ErrorMessage = "Por favor, informe o tipo.")]
        public int? Opcao { get; set; }
    }
}
