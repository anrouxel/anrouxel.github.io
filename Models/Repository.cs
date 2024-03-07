using System.Text.Json.Serialization;

namespace anrouxel.Models
{
    public class Repository
    {
        public int id { get; set; }

        public string? node_id { get; set; }

        public string? name { get; set; }

        public string? full_name { get; set; }

        [JsonPropertyName("private")]
        public bool private_repo { get; set; }

        public Profile? owner { get; set; }

        public Uri? html_url { get; set; }

        public string? description { get; set; }

        public bool fork { get; set; }

        public Uri? url { get; set; }

        public Uri? forks_url { get; set; }

        public Uri? keys_url { get; set; }

        public Uri? collaborators_url { get; set; }

        public Uri? teams_url { get; set; }

        public Uri? hooks_url { get; set; }

        public Uri? issue_events_url { get; set; }

        public Uri? events_url { get; set; }

        public Uri? assignees_url { get; set; }

        public Uri? branches_url { get; set; }

        public Uri? tags_url { get; set; }

        public Uri? blobs_url { get; set; }

        public Uri? git_tags_url { get; set; }

        public Uri? git_refs_url { get; set; }

        public Uri? trees_url { get; set; }

        public Uri? statuses_url { get; set; }

        public Uri? languages_url { get; set; }

        public Uri? stargazers_url { get; set; }

        public Uri? contributors_url { get; set; }

        public Uri? subscribers_url { get; set; }

        public Uri? subscription_url { get; set; }

        public Uri? commits_url { get; set; }

        public Uri? git_commits_url { get; set; }

        public Uri? comments_url { get; set; }

        public Uri? issue_comment_url { get; set; }

        public Uri? contents_url { get; set; }

        public Uri? compare_url { get; set; }

        public Uri? merges_url { get; set; }

        public Uri? archive_url { get; set; }

        public Uri? downloads_url { get; set; }

        public Uri? issues_url { get; set; }

        public Uri? pulls_url { get; set; }

        public Uri? milestones_url { get; set; }

        public Uri? notifications_url { get; set; }

        public Uri? labels_url { get; set; }

        public Uri? releases_url { get; set; }

        public Uri? deployments_url { get; set; }

        public DateTimeOffset created_at { get; set; }

        public DateTimeOffset updated_at { get; set; }

        public DateTimeOffset pushed_at { get; set; }

        public Uri? git_url { get; set; }

        public Uri? ssh_url { get; set; }

        public Uri? clone_url { get; set; }

        public Uri? svn_url { get; set; }

        public string? homepage { get; set; }

        public int size { get; set; }

        public int stargazers_count { get; set; }

        public int watchers_count { get; set; }

        public string? language { get; set; }

        public bool has_issues { get; set; }

        public bool has_projects { get; set; }

        public bool has_downloads { get; set; }

        public bool has_wiki { get; set; }

        public bool has_pages { get; set; }

        public int forks_count { get; set; }

        public Uri? mirror_url { get; set; }

        public bool archived { get; set; }

        public bool disabled { get; set; }

        public int open_issues_count { get; set; }

        public License? license { get; set; }

        public bool allow_forking { get; set; }

        public bool is_template { get; set; }

        public bool web_commit_signoff_required { get; set; }

        public Object[]? topics { get; set; }

        public string? visibility { get; set; }

        public int forks { get; set; }

        public int open_issues { get; set; }

        public int watchers { get; set; }

        public string? default_branch { get; set; }
    }
}