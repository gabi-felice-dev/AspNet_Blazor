using AppContas.Web;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//Mapeamento injeção de dependência para a classe HttpClient
builder.Services.AddScoped(sp => new HttpClient
{
    //Configuração de endereço padrão (default)
    BaseAddress = new Uri("http://appcontas1-001-site1.ctempurl.com/api/")
});

await builder.Build().RunAsync();



