namespace PizzaFactory.Foundations.Ingredients.Doughs;

public class CustomDough:IDough
{
    private string _name = nameof(CustomDough);

    public string GetName() => _name;
}