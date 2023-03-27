namespace PizzaFactory.Foundations.Ingredients.Cheeses;

public class MonterreyCheese:ICheese
{
    private string _name = nameof(MonterreyCheese);
    public string GetName() => _name;
}