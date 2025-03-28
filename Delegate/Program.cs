using Delegate;

class Program
{
    delegate string IntToString(int i);
    static void Main(string[] args)
    {
        IntToString methodRef = AddNumberSign;
        Console.WriteLine(methodRef(12345));
        Console.WriteLine(AddNumberSign(12345));

        methodRef = PlusOne;
        Console.WriteLine(methodRef(12345));

        var adrian = new Adrian();
        var harper = new Harper();
        GetSecretIngredient addIngredientMethod = null;
        while (true)
        {
            Console.Write("Enter A for Adrian, H for Harper, or an amount: ");
            var line = Console.ReadLine();
            switch (line)
            {
                case "A":
                    Console.WriteLine("Selected Adrian");
                    addIngredientMethod = adrian.MySecretIngredientMethod;
                    break;
                case "H":
                    Console.WriteLine("Selected Harper");
                    addIngredientMethod = harper.HarpersSecretIngredientMethod;
                    break;
                default:
                    if (addIngredientMethod is null)
                        Console.WriteLine("Please select a chef!");
                    else if (int.TryParse(line, out int amount))
                        Console.WriteLine(addIngredientMethod(amount));
                    else
                        return;
                    break;
            }
        }
    }
    public static string AddNumberSign(int i) => $"#{i}";
    public static string PlusOne(int i) => $"{i} plus one equals {i + 1}";
}