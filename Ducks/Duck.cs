namespace Ducks;

enum KindOfDuck
{
    Mallard,
    Muscovy,
    Loon,
}

internal class Duck
{
    public int Size { get; set; }
    public KindOfDuck Kind { get; set; }

    public override string ToString()
    {
        return $"A {Size} inch {Kind}";
    }
}
