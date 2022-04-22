using AsyncProgramming.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncProgramming;

public class App
{

    private JokeService _jokeService;

    public App(JokeService? jokeService = null)
    {
        _jokeService = jokeService ?? new JokeService();
    }

    public async Task Run()
    {
        var jokes = await _jokeService.GetMultipleRandomJoke(10);

        foreach (var joke in jokes)
        {
            DisplayJoke(joke);
        }

    }

    private static void DisplayJoke(Models.Joke? joke)
    {
        if (joke != null)
        {
            Console.WriteLine(joke.Setup);
            Console.WriteLine(joke.Delivery);
        }
    }

}
