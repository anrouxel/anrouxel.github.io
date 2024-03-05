using System.Net.Http.Json;
using anrouxel.Configurations;
using anrouxel.Models;
using Microsoft.Extensions.Options;

namespace anrouxel.Services
{
    public interface IGithubService
    {
        Task<Profile?> GetProfileAsync();

        Task<Repository[]?> GetRepositoriesAsync();

        Task<string?> GetAvatarAsync();
    }
}