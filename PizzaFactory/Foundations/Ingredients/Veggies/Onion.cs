namespace PizzaFactory.Foundations.Ingredients.Veggies;

public class Onion:IVeggies
{
    private string _name = nameof(Onion);
    public string GetName() => _name;
}