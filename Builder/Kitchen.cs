namespace Builder;

public class Kitchen
{
    public void CreateSandwich(SandwichBuilder builder){
        builder.OpenBread();
        builder.AddIngredients();
        builder.CloseBread();
    }
}