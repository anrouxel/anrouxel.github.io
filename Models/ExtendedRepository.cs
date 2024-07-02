using Octokit;

namespace anrouxel.Models
{
    public class ExtendedRepository
    {
        public ExtendedRepository(Repository repository, IReadOnlyList<RepositoryLanguage> languages)
        {
            Repository = repository;
            Languages = languages;
        }

        public Repository Repository { get; private set; }

        public IReadOnlyList<RepositoryLanguage> Languages { get; private set; }
    }
}