using AsyncProgramming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AsyncProgramming.Clients;

public class JokeClient
{

    const string url = "https://v2.jokeapi.dev/joke/Any?type=twopar";


    public async Task<Joke?> GetRandomJoke()
    {

        // TODO :
        //  - Create HttpClient
        //  - Gerer les erreurs?
        //  - Utiliser ReadAsStreamAsync
        //  -
        using var client = new HttpClient();
        using var response = await client.GetAsync(url);
        var json = await response.Content.ReadAsStringAsync();
        var result = JsonSerializer.Deserialize<Joke>(json);
        return result;
    }

}

