
using System.Net.Http.Json;
using anrouxel.Models;
using anrouxel.Services;
using Microsoft.AspNetCore.Components;

namespace anrouxel.Pages.Home.Sections
{
    public partial class Projects
    {
        [Inject]
        private NavigationManager navigationManager { get; set; } = null!;

        [Inject]
        private IGithubService _githubService { get; set; } = null!;

        private List<Repository> repositories = new List<Repository>();

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                repositories = await _githubService.GetRepositoriesAsync();
                StateHasChanged();
            }
        }

        private string CalculateTimeDifference(DateTimeOffset time)
        {
            DateTimeOffset now = DateTimeOffset.Now;
            TimeSpan difference = now - time;

            if (difference.TotalDays >= 365)
            {
                return $"{(int)(difference.TotalDays / 365)} année{(difference.TotalDays >= 730 ? "s" : "")}";
            }
            else if (difference.TotalDays >= 30)
            {
                return $"{(int)(difference.TotalDays / 30)} mois";
            }
            else if (difference.TotalDays >= 1)
            {
                return $"{(int)difference.TotalDays} jour{(difference.TotalDays >= 2 ? "s" : "")}";
            }
            else if (difference.TotalHours >= 1)
            {
                return $"{(int)difference.TotalHours} heure{(difference.TotalHours >= 2 ? "s" : "")}";
            }
            else if (difference.TotalMinutes >= 1)
            {
                return $"{(int)difference.TotalMinutes} minute{(difference.TotalMinutes >= 2 ? "s" : "")}";
            }
            else if (difference.TotalSeconds >= 1)
            {
                return $"{(int)difference.TotalSeconds} seconde{(difference.TotalSeconds >= 2 ? "s" : "")}";
            } else {
                return "à l'instant";
            }
        }

        private void navigateTo(string uri)
        {
            navigationManager.NavigateTo(uri, true);
        }
    }
}