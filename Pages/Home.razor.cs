
using System.Net.Http.Json;
using anrouxel.Models;
using Microsoft.AspNetCore.Components;

namespace anrouxel.Pages
{
    public partial class Home
    {
        [Inject]
        private NavigationManager navigationManager { get; set; } = null!;

        private readonly Github github = new Github();

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                using (var httpClient = new HttpClient())
                {
                    github.profile = await httpClient.GetFromJsonAsync<Profile>(Github.GITHUB_API_URL);
                    github.repositories = await httpClient.GetFromJsonAsync<Repository[]>(github.profile!.repos_url);
                    StateHasChanged();
                }
            }
        }

        private void navigateTo(string uri)
        {
            navigationManager.NavigateTo(uri, true);
        }
    }
}