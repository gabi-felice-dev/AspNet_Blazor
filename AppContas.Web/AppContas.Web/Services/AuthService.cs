using AppContas.Web.Responses;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;

namespace AppContas.Web.Services
{
    /// <summary>
    /// Classe de serviço para operações de autenticação de usuários
    /// </summary>
    public class AuthService
    {
        //atributos
        private readonly ILocalStorageService _localStorageService;
        private readonly NavigationManager _navigationManager;

        private const string _key = "appcontas-auth";

        //Método para injeção de dependência
        public AuthService(ILocalStorageService localStorageService, NavigationManager navigationManager)
        {
            _localStorageService = localStorageService;
            _navigationManager = navigationManager;
        }

        /// <summary>
        /// Método para salvar os dados de autenticação do usuário
        /// </summary>
        public async Task SignIn(AutenticarResponse data)
        {
            await _localStorageService.SetItemAsync(_key, data);
        }

        /// <summary>
        /// Método para verificar se o usuário está autenticado
        /// </summary>
        public async Task<bool> IsSigningIn()
        {
            var data = await _localStorageService.GetItemAsync<AutenticarResponse>(_key);
            return data != null && data.DataExpiracao >= DateTime.Now;
        }

        /// <summary>
        /// Método para retornar os dados de autenticação do usuário
        /// </summary>
        public async Task<AutenticarResponse> GetData()
        {
            return await _localStorageService.GetItemAsync<AutenticarResponse>(_key);
        }

        /// <summary>
        /// Apagar as informações de autenticação do usuário
        /// </summary>
        public async Task SignOut()
        {
            await _localStorageService.RemoveItemAsync(_key);
        }

        /// <summary>
        /// Método para verificar se o usuário está autenticado
        /// E caso não esteja, redireciona-lo de volta para a página inicial do sistema
        /// </summary>
        public async Task Authorize(bool isAuthenticated)
        {
            var isSigningIn = await IsSigningIn();

            //O Usuário não está autenticado em uma página
            //em que ele precisa de autenticação
            if (!isSigningIn && isAuthenticated)
                _navigationManager.NavigateTo("/");

            //O Usuário está autenticado em uma página
            //em que ele não precisa de autenticação
            else if(isSigningIn && !isAuthenticated)
                _navigationManager.NavigateTo("/admin/dashboard");
        }
    }
}
