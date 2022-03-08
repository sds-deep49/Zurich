using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Zurich.Domain.Interfaces.Services;
using Zurich.Domain.Models;

namespace Zurich.Services
{
    public class UserServices : IUserServices
    {
        private readonly HttpClient _httpClient;
        private const string path = "public/v2/users";

        public UserServices(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            return await _httpClient.GetFromJsonAsync<User[]>(path);
        }
    }
}
