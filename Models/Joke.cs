using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AsyncProgramming.Models;

public partial class Joke
{
    [JsonPropertyName("error")]
    public bool Error { get; set; }

    [JsonPropertyName("category")]
    public string Category { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("setup")]
    public string Setup { get; set; }

    [JsonPropertyName("delivery")]
    public string Delivery { get; set; }

    [JsonPropertyName("id")]
    public long Id { get; set; }

    [JsonPropertyName("safe")]
    public bool Safe { get; set; }

    [JsonPropertyName("lang")]
    public string Lang { get; set; }
}
