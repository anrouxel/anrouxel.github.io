namespace anrouxel.Models
{
    public class Profile
    {
        public string? login { get; set; }

        public int id { get; set; }

        public string? node_id { get; set; }

        public string? avatar_url { get; set; }

        public string? gravatar_id { get; set; }

        public Uri? url { get; set; }

        public Uri? html_url { get; set; }

        public Uri? followers_url { get; set; }

        public Uri? following_url { get; set; }

        public Uri? gists_url { get; set; }

        public Uri? starred_url { get; set; }

        public Uri? subscriptions_url { get; set; }

        public Uri? organizations_url { get; set; }

        public Uri? repos_url { get; set; }

        public Uri? events_url { get; set; }

        public Uri? received_events_url { get; set; }

        public string? type { get; set; }

        public bool site_admin { get; set; }

        public string? name { get; set; }

        public string? company { get; set; }

        public string? blog { get; set; }

        public string? location { get; set; }

        public string? email { get; set; }

        public string? hireable { get; set; }

        public string? bio { get; set; }

        public string? twitter_username { get; set; }

        public int public_repos { get; set; }

        public int public_gists { get; set; }

        public int followers { get; set; }

        public int following { get; set; }

        public string? created_at { get; set; }

        public string? updated_at { get; set; }
    }
}