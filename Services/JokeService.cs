using AsyncProgramming.Clients;
using AsyncProgramming.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgramming.Services;

public class JokeService
{

    private readonly JokeClient _jokeClient;


    public JokeService(JokeClient? jokeClient = null)
    {
        _jokeClient = jokeClient ?? new JokeClient();
    }

    public Task<Joke?> GetRandomJoke()
    {
        return _jokeClient.GetRandomJoke();
    }

    public async Task<IEnumerable<Joke?>> GetMultipleRandomJoke(int n)
    {

        var tasks = new List<Task<Joke?>>();

        for (int i = 0; i < n; i++)
        {
            var task = _jokeClient.GetRandomJoke();
            _ = task.ContinueWith((task) =>
           {
               // ContinueWith do smth after it received the data
               Console.WriteLine(i);
           });
            tasks.Add(task);
        }


        var jokes = await Task.WhenAll(tasks);


        // RETURN TYPE List<Task<Joke?>>
        //await Task.WhenAll(tasks);
        //Task.WaitAny(); // take the first response
        //var jokes = new List<Joke?>();

        //foreach (var task in tasks)
        //{
        //    jokes.Add(task.Result);
        //}

        return jokes;
        // Task.FromResult() => perfect for error case
    }

}
