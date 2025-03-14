namespace Comics;

internal class Program
{
    static void Main(string[] args)
    {
        var mostExpensive = Comic.Catalog
            .Where(c => Comic.Prices[c.Issue] > 500)
            .OrderBy(c => Comic.Prices[c.Issue])
            .Select(c => $"{c} is worth {Comic.Prices[c.Issue]:c}");
        foreach (var comic in mostExpensive)
        {
            Console.WriteLine(comic);
        }
    }
}
