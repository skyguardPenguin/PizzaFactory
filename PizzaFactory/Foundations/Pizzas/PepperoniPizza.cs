using PizzaFactory.Foundations.IngredientFactories;
using PizzaFactory.Tools;

namespace PizzaFactory.Foundations.Pizzas;

public class PepperoniPizza:Pizza
{
    private IPizzaIngredientFactory _ingredientFactory;

    public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }
    public override void Prepare()
    {
        CustomWritter.WriteLine($"Preparing the pizza {_name}...", ConsoleColor.Green);
        _pepperoni = _ingredientFactory.CreatePepperoni();
        _dough = _ingredientFactory.CreateDough();
        _sauce = _ingredientFactory.CreateSauce();
    }
}