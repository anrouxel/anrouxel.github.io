using System.Reactive.Linq;
using System.Text.Json;
using anrouxel.Configurations;
using Microsoft.Extensions.Options;
using Octokit;
using Octokit.Reactive;

namespace anrouxel.Services
{
    public class GithubService: IGithubService
    {
        private readonly GithubSettings _githubSettings;

        private readonly ObservableGitHubClient _client;

        public GithubService(
            IOptions<GithubSettings> githubSettings
        ) {
            _githubSettings = githubSettings.Value;
            _client = new ObservableGitHubClient(new ProductHeaderValue(_githubSettings.GITHUB_PROFILE));
        }

        public IObservable<User> GetProfileAsync()
        {
            return _client.User.Get(_githubSettings.GITHUB_PROFILE);
        }

        public IObservable<Repository> GetRepositoriesAsync()
        {
            return _client.Repository.GetAllForUser(_githubSettings.GITHUB_PROFILE);
        }

        public IObservable<Repository> GetBestRepositoriesAsync() {
            return _client.Repository.GetAllForUser(_githubSettings.GITHUB_PROFILE).Where(repo => _githubSettings.GITHUB_BEST_REPOS.Contains(repo.Name));
        }
    }
}