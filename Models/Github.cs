namespace anrouxel.Models
{
    public class Github
    {
        public const string GITHUB_API_URL = "https://api.github.com/users/anrouxel";

        public Profile? profile { get; set; }

        public Repository[]? repositories { get; set; }
    }
}
