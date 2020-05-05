# StashClient
A simple Atlassian Stash REST api client using RestSharp

# Usage
You can define your own RestSharp.RestClient to perforn the requests.

```c#
RestClient baseClient = ...
StashRestClient stash = new StashRestClient(baseClient);
foreach (StashClient.Objects.Project p in stash.GetAllProjects())
{
  Console.WriteLine(p.Name);
}
```

You can also use the standard client from the API with no authentication.

```c#
StashRestClient stash = new StashRestClient("http://your_stash_server_url:7990/");
foreach (StashClient.Objects.Project p in stash.GetAllProjects())
{
  Console.WriteLine(p.Name);
}
```

Or use your own credentials with basic authentication.

```c#
StashRestClient stash = new StashRestClient("http://your_stash_server_url:7990/", "username", "password");
foreach (StashClient.Objects.Project p in stash.GetAllProjects())
{
  Console.WriteLine(p.Name);
}
```
