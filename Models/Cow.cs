using System;

public class Cow : Animal
{
    public Cow()
    {
        Type = "Cow";
    }

    public override string MakeSound() => "Cow: Moo... Moo...";

    public override int GiveBirth() => new Random().Next(1, 4);  // Cows give birth to 1-3 offspring

    public override int ProduceMilk() => new Random().Next(0, 21);  // Cows produce 0-20 liters of milk
}