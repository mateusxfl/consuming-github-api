/*
    "user_url": "https://api.github.com/users/{user}",
    "repos_url": "https://api.github.com/users/mateusxfl/repos",
*/


using Newtonsoft.Json;
using ConsumindoGithub.Entities;

Console.Clear();

await GetUsers("mateusxfl");
await GetRepos("mateusxfl");

async Task GetUsers(string username)
{
    HttpClient client = new HttpClient { BaseAddress = new Uri("https://api.github.com") };
    client.DefaultRequestHeaders.Add("User-Agent", "request");
    var response = await client.GetAsync($"users/{username}");
    var content = await response.Content.ReadAsStringAsync();
    User user = JsonConvert.DeserializeObject<User>(content);
    Console.WriteLine($"{user.Login} - {user.AvatarUrl} - {user.HtmlUrl} - {user.ReposUrl} \n");
}

async Task GetRepos(string username)
{
    HttpClient client = new HttpClient { BaseAddress = new Uri("https://api.github.com") };
    client.DefaultRequestHeaders.Add("User-Agent", "request");
    var response = await client.GetAsync($"users/{username}/repos");
    var content = await response.Content.ReadAsStringAsync();
    Repo[] repos = JsonConvert.DeserializeObject<Repo[]>(content);
    foreach (var repo in repos)
    {
        Console.WriteLine($"{repo.Id} - {repo.FullName} - {repo.Description} - {repo.Language}");
    }
    Console.WriteLine();
}