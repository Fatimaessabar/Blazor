using Blazor.Shared;
using System.Net.Http.Json;

namespace Blazor.Client.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly HttpClient _http;

        public UserService(HttpClient http)
        {
            _http = http;
        }
        public async Task<List<User>> GetUsers()
        {
            var response = await _http.GetFromJsonAsync<ServiceResponse<List<User>>>("api/User");
            return response.Data;
        }
    }
}
