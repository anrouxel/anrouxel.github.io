
using System.Net.Http.Json;
using anrouxel.Models;
using anrouxel.Services;
using Microsoft.AspNetCore.Components;

namespace anrouxel.Pages
{
    public partial class Home
    {
        [Inject]
        private NavigationManager navigationManager { get; set; } = null!;

        [Inject]
        private IGithubService _githubService { get; set; } = null!;

        private Profile? profile { get; set; }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                profile = await _githubService.GetProfileAsync();
                StateHasChanged();
            }
        }

        private void navigateTo(string uri)
        {
            navigationManager.NavigateTo(uri, true);
        }
    }
}