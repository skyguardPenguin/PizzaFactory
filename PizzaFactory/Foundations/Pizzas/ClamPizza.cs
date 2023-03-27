using PizzaFactory.Foundations.IngredientFactories;
using PizzaFactory.Tools;

namespace PizzaFactory.Foundations.Pizzas;

public class ClamPizza:Pizza
{
    
    private IPizzaIngredientFactory _ingredientFactory;

    public ClamPizza(IPizzaIngredientFactory ingredientFactory)
    {
        _ingredientFactory = ingredientFactory;
    }
    public override void Prepare()
    {
        CustomWritter.WriteLine($"Preparing the pizza {_name}...", ConsoleColor.Green);
        _clams = _ingredientFactory.CreateClam();
        _dough = _ingredientFactory.CreateDough();
        _sauce = _ingredientFactory.CreateSauce();


    }
}