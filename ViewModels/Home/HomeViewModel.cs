using anrouxel.Services;
using Microsoft.AspNetCore.Components;
using System.Reactive;
using System.Threading.Tasks;
using ReactiveUI;
using Octokit;
using System.Reactive.Linq;

// View Model qui va gérer la page d'accueil (récupération des données de l'utilisateur)
namespace anrouxel.ViewModels
{
    public class HomeViewModel: ReactiveObject
    {
        private readonly IGithubService _githubService;

        private readonly ObservableAsPropertyHelper<User> _profile;

        public HomeViewModel(IGithubService githubService) {
            _githubService = githubService;

            GetProfile = ReactiveCommand.CreateFromTask(GetProfileAsync);

            _profile = GetProfile.ToProperty(this, x => x.Profile);
        }

        public ReactiveCommand<Unit, User> GetProfile { get; }

        public User Profile => _profile.Value;

        private async Task<User> GetProfileAsync() {
            return await _githubService.GetProfileAsync();
        }
    }
}