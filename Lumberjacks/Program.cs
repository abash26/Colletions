﻿namespace Lumberjacks;

internal class Program
{
    static void Main(string[] args)
    {
        var random = new Random();
        Queue<Lumberjack> lumberjacks = new Queue<Lumberjack>();

        string name;
        Console.Write("First lumberjack's name: ");
        while ((name = Console.ReadLine()) != "")
        {
            Console.Write("Number of flapjacks: ");
            if (int.TryParse(Console.ReadLine(), out int num))
            {
                Lumberjack lumberjack = new Lumberjack(name);
                for (int i = 0; i < num; i++)
                {
                    lumberjack.TakeFlapjack((Flapjack)random.Next(0, 4));
                }
                lumberjacks.Enqueue(lumberjack);
            }
            Console.Write("Next lumberjack's name (blank to end): ");
        }
        while (lumberjacks.Count > 0)
        {
            Lumberjack next = lumberjacks.Dequeue();
            next.EatFlapjacks();
        }
    }
}
