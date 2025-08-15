using EstimationToolMcp.Model;
using Microsoft.Extensions.Options;

namespace EstimationToolMcp.Service
{
    public class UserService: IUserService
    {
        private readonly HttpClient _httpClient;

        private readonly ServiceConfiguration _configuration;

        public UserService(IHttpClientFactory httpClientFactory, IOptions<ServiceConfiguration> options)
        {
            _httpClient = httpClientFactory.CreateClient();
            _configuration = options.Value;
        }

        public async Task<string> GetUsersAsync()
        {
            var users = "No users found";

            var response = await _httpClient.GetAsync($"{_configuration.BaseUrl}/api/Auth/users");
            if (response.IsSuccessStatusCode)
            {
                users = await response.Content.ReadAsStringAsync(); ;
            }

            return users;
        }
    }
}
