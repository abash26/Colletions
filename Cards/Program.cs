namespace Cards;

internal class Program
{
    private static readonly Random random = new Random();
    static void Main(string[] args)
    {
        int randomSuit = random.Next(4);
        int randomValue = random.Next(1, 14);
        Card card = new Card((Suit)randomSuit, (Value)randomValue);
        Console.WriteLine(card.Name);


    }
}
