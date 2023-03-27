namespace PizzaFactory.Foundations.Ingredients.Veggies;

public class Mushroom:IVeggies
{
    private string _name => nameof(Mushroom);
    public string GetName() => _name;
}