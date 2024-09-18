using System;

public abstract class Animal
{
    public string Type { get; set; }
    public int Quantity { get; set; }

    public abstract string MakeSound();

    public abstract int GiveBirth();

    public abstract int ProduceMilk();
}