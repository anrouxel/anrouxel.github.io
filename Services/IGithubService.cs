using Octokit;

namespace anrouxel.Services
{
    public interface IGithubService
    {
        IObservable<User> GetProfileAsync();

        IObservable<Repository> GetRepositoriesAsync();

        IObservable<Repository> GetBestRepositoriesAsync();

        IObservable<RepositoryLanguage> GetLanguagesForRepository(long repositoryId);
    }
}