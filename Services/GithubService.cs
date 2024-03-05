using System.Net.Http.Json;
using anrouxel.Configurations;
using anrouxel.Models;
using Microsoft.Extensions.Options;

namespace anrouxel.Services
{
    public class GithubService : IGithubService
    {
        private readonly HttpClient _httpClient;

        public GithubService(
            IOptions<GithubSettings> githubSettings
        ) {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(githubSettings.Value.GITHUB_API_URL);

            Console.WriteLine($"Github API URL: {githubSettings.Value.GITHUB_API_URL}");
            Console.WriteLine($"HttpClient BaseAddress: {_httpClient.BaseAddress}");
        }

        public async Task<Profile?> GetProfileAsync()
        {
            return await _httpClient.GetFromJsonAsync<Profile>("");
        }

        public async Task<Repository[]?> GetRepositoriesAsync()
        {
            return await _httpClient.GetFromJsonAsync<Repository[]>("/repos");
        }

        public async Task<string?> GetAvatarAsync()
        {
            var avatar_url = await _httpClient.GetFromJsonAsync<Profile>("");

            Console.WriteLine(avatar_url!.avatar_url);

            return avatar_url!.avatar_url;
        }
    }
}