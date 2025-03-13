﻿namespace Birds;

enum KindOfDuck
{
    Mallard,
    Muscovy,
    Loon,
}

internal class Duck : Bird
{
    public int Size { get; set; }
    public KindOfDuck Kind { get; set; }

    public override string ToString()
    {
        return $"A {Size} inch {Kind}";
    }
}
