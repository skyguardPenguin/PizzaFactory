using PizzaFactory.Foundations.IngredientFactories;
using PizzaFactory.Foundations.Pizzas;

namespace PizzaFactory.Foundations.PizzaStores;

public class ChicagoPizzaStore:PizzaStore
{
    protected override Pizza CreatePizza(string item)
    {
        IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();
        Pizza pizza;
        switch (item)
        {
            case"cheese":
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("Chicago style cheese pizza");
                break;
            case"pepperoni":
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("Chicago style pepperoni pizza");
                break;
            case "veggie":
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("Chicago style veggie pizza");
                break;
            case "clam":
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("Chicago style clams pizza");
                break;
            default:
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("Chicago style pepperoni pizza");
                break;
        }

        return pizza;
    }
}