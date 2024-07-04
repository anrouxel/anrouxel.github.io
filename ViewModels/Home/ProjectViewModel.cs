using System.Reactive;
using System.Reactive.Linq;
using anrouxel.Models;
using anrouxel.Services;
using DynamicData;
using Octokit;
using ReactiveUI;

namespace anrouxel.ViewModels
{
    public class ProjectViewModel : ReactiveObject
    {
        private readonly IGithubService _githubService;

        private readonly ObservableAsPropertyHelper<IEnumerable<Repository>> _repositories;

        public ProjectViewModel(IGithubService githubService)
        {
            _githubService = githubService;

            GetRepositories = ReactiveCommand.CreateFromObservable(GetRepositoriesAsync);

            _repositories = GetRepositories
                .Select(repos => repos.OrderBy(repo => repo.Name))
                .ToProperty(this, x => x.Repositories);
        }

        public ReactiveCommand<Unit, IEnumerable<Repository>> GetRepositories;

        public IEnumerable<Repository> Repositories => _repositories.Value;

        private IObservable<IEnumerable<Repository>> GetRepositoriesAsync()
        {
            return _githubService.GetBestRepositoriesAsync().ToList();
        }
    }
}