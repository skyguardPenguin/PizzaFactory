namespace PizzaFactory.Foundations.Ingredients.Clams;

public class FrozenClams:IClams
{
    private string _name = nameof(FrozenClams);
    public string GetName() => _name;
}