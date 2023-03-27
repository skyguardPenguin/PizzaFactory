using PizzaFactory.Foundations.IngredientFactories;
using PizzaFactory.Tools;

namespace PizzaFactory.Foundations.Pizzas;

public class VeggiePizza:Pizza
{
    private IPizzaIngredientFactory _ingredientFactory;

    public VeggiePizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }
    public override void Prepare()
    {
        CustomWritter.WriteLine($"Preparing the pizza {_name}...", ConsoleColor.Green);
        _veggies = _ingredientFactory.CreateVeggies();
        _dough = _ingredientFactory.CreateDough();
        _sauce = _ingredientFactory.CreateSauce();
    }
}