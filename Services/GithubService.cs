using System.Net.Http.Json;
using anrouxel.Configurations;
using anrouxel.Models;
using Microsoft.Extensions.Options;

namespace anrouxel.Services
{
    public class GithubService : IGithubService
    {
        private readonly GithubSettings _githubSettings;

        private readonly HttpClient _httpClient;

        public GithubService(
            IOptions<GithubSettings> githubSettings
        ) {
            _githubSettings = githubSettings.Value;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(githubSettings.Value.GITHUB_API_URL);
        }

        private string MakeUrl(string? path)
        {
            if (path == null)
            {
                return _githubSettings.GITHUB_PROFILE_URL;
            }
            return $"{_githubSettings.GITHUB_PROFILE_URL}/{path}";
        }

        public async Task<Profile?> GetProfileAsync()
        {
            return await _httpClient.GetFromJsonAsync<Profile>(MakeUrl(null));
        }

        public async Task<List<Repository>> GetRepositoriesAsync()
        {
            var repositories = await _httpClient.GetFromJsonAsync<List<Repository>>(MakeUrl("repos"));
            if (repositories == null)
            {
                return new List<Repository>();
            }
            return repositories;
        }
    }
}