namespace PizzaFactory.Foundations.Ingredients.Pepperonies;

public class CustomPepperoni:IPepperoni
{
    private string _name = nameof(CustomPepperoni);

    public string GetName() => _name;
}