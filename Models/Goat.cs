using System;

public class Goat : Animal
{
    public Goat()
    {
        Type = "Goat";
    }

    public override string MakeSound() => "Goat: Bleat... Bleat...";

    public override int GiveBirth() => new Random().Next(1, 4);  // Goats give birth to 1-3 offspring

    public override int ProduceMilk() => new Random().Next(0, 11);  // Goats produce 0-10 liters of milk
}
