namespace PizzaFactory.Foundations.Ingredients.Cheeses;

public class MozzarelaCheese:ICheese
{
    private string _name = nameof(MozzarelaCheese);

    public string GetName() => _name;
}