namespace Cards;

internal class Program
{
    private static readonly Random random = new Random();

    static Card RandomCard()
    {
        return new Card((Suit)random.Next(4), (Value)random.Next(1, 14));
    }
    static void Main(string[] args)
    {
        while (true)
        {
            List<Card> cards = new List<Card>();
            CardComparer cardComparer = new CardComparer();

            Console.WriteLine("Enter number of cards:");
            if (int.TryParse(Console.ReadLine(), out int numOfCards))
            {
                for (int i = 0; i < numOfCards; i++)
                {
                    cards.Add(RandomCard());
                }
            }
            cards.Sort(cardComparer);
            PrintCards(cards);
        }
    }

    public static void PrintCards(List<Card> cards)
    {
        foreach (Card card in cards)
        {
            Console.WriteLine(card);
        }
    }

}
