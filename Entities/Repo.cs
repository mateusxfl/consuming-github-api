using Newtonsoft.Json;

namespace ConsumindoGithub.Entities
{
    public class Repo
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("owner")]
        public User User { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("description")]
        public object Description { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("clone_url")]
        public Uri CloneUrl { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("default_branch")]
        public string DefaultBranch { get; set; }
    }
}