namespace Builder;

public abstract class SandwichBuilder
{
    public abstract void OpenBread();
    public abstract void AddIngredients();
    public abstract void CloseBread();
    public abstract Sandwich GetSandwich(); 
}