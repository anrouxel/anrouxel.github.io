using Octokit;

namespace anrouxel.Services
{
    public interface IGithubService
    {
        IObservable<User> GetProfileAsync();

        IObservable<Repository> GetRepositoriesAsync();
    }
}