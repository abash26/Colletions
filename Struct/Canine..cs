﻿namespace Struct;

public class Canine
{
    public string Name { get; set; }
    public string Breed { get; set; }
    public Canine(string name, string breed)
    {
        this.Name = name;
        this.Breed = breed;
    }

    public void Speak()
    {
        Console.WriteLine("My name is {0} and I'm a {1}.", Name, Breed);
    }
}