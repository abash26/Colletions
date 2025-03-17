using System.Text.Json;

namespace JSON;

internal class Program
{
    static void Main(string[] args)
    {
        var guys = new List<Guy>()
        {
            new() { Name = "Bob", Clothes = new Outfit() { Top = "t-shirt", Bottom = "jeans" },
            Hair = new HairStyle() { Color = HairColor.Red, Length = 3.5f }
            },
            new() { Name = "Joe", Clothes = new Outfit() { Top = "polo", Bottom = "slacks" },
            Hair = new HairStyle() { Color = HairColor.Gray, Length = 2.7f }
            },
        };

        var options = new JsonSerializerOptions() { WriteIndented = true };
        var jsonString = JsonSerializer.Serialize(guys, options);
        Console.WriteLine(jsonString);

        var copy = JsonSerializer.Deserialize<List<Guy>>(jsonString);
        foreach (var guy in copy)
            Console.WriteLine("I deserialized this guy: {0}", guy);


        Console.WriteLine(JsonSerializer.Serialize(3));
        Console.WriteLine(JsonSerializer.Serialize((long)-3));
        Console.WriteLine(JsonSerializer.Serialize((byte)0));
        Console.WriteLine(JsonSerializer.Serialize(float.MaxValue));
        Console.WriteLine(JsonSerializer.Serialize(float.MinValue));
        Console.WriteLine(JsonSerializer.Serialize(true));
        Console.WriteLine(JsonSerializer.Serialize("Elephant"));
        Console.WriteLine(JsonSerializer.Serialize("Elephant".ToCharArray()));
        Console.WriteLine(JsonSerializer.Serialize(" "));
    }
}
