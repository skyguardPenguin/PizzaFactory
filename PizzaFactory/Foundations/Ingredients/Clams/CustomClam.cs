namespace PizzaFactory.Foundations.Ingredients.Clams;

public class CustomClam:IClams
{
    private string _name = nameof(CustomClam);
    public string GetName() => _name;
}