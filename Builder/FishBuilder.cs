using System;

namespace Builder;

public class FishBuilder : SandwichBuilder
{
    private Sandwich _sandwich = new FishBurger();
    
    public override void OpenBread()
    {
        Console.WriteLine("Open Bread");
    }

    public override void AddIngredients()
    {
        Console.WriteLine("Add Ingredients");
    }

    public override void CloseBread()
    {
        Console.WriteLine("Close Bread");
    }

    public override Sandwich GetSandwich()
    {
        Console.WriteLine("Fish Burger Done!");
        return _sandwich;
    }
}