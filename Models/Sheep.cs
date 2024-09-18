using System;

public class Sheep : Animal
{
    public Sheep()
    {
        Type = "Sheep";
    }

    public override string MakeSound() => "Sheep: Baa... Baa...";

    public override int GiveBirth() => new Random().Next(1, 3);  // Sheep give birth to 1-2 offspring

    public override int ProduceMilk() => new Random().Next(0, 6);  // Sheep produce 0-5 liters of milk
}