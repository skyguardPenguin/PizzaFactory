using PizzaFactory.Foundations.IngredientFactories;
using PizzaFactory.Tools;

namespace PizzaFactory.Foundations.Pizzas;

public class CheesePizza:Pizza
{
    private IPizzaIngredientFactory _ingredientFactory;

    public CheesePizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }
    public override void Prepare()
    {
        CustomWritter.WriteLine($"Preparing the pizza {_name}...", ConsoleColor.Green);
        _cheese = _ingredientFactory.CreateCheese();
        _dough = _ingredientFactory.CreateDough();
        _sauce = _ingredientFactory.CreateSauce();
    }
}