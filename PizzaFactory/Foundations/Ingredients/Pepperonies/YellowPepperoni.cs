namespace PizzaFactory.Foundations.Ingredients.Pepperonies;

public class YellowPepperoni:IPepperoni
{
    private string _name = nameof(YellowPepperoni);

    public string GetName() => _name;
}