﻿namespace Comics;

internal class Program
{
    static void Main(string[] args)
    {
        var mostExpensive = 
            from comic in Comic.Catalog
            where Comic.Prices[comic.Issue] > 500
            orderby Comic.Prices[comic.Issue]
            select $"{comic} is worth {Comic.Prices[comic.Issue]:c}";

        foreach (var comic in mostExpensive)
        {
            Console.WriteLine(comic);
        }
    }
}
