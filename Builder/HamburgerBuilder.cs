using System;

namespace Builder;

public class HamburgerBuilder : SandwichBuilder
{
    private Sandwich _sandwich = new Hamburger();
    
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
        Console.WriteLine("Hamburger Done!");
        return _sandwich;
    }
}