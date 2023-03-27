using PizzaFactory.Foundations.IngredientFactories;
using PizzaFactory.Foundations.Pizzas;

namespace PizzaFactory.Foundations.PizzaStores;

public class NYPizzaStore:PizzaStore
{

    protected override Pizza CreatePizza(string item)
    {
        IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
        Pizza pizza;
        switch (item)
        {
            case"cheese":
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("NY style cheese pizza");
                break;
            case"pepperoni":
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("NY style pepperoni pizza");
                break;
            case "veggie":
                pizza = new VeggiePizza(ingredientFactory);
                pizza.SetName("NY style veggie pizza");
                break;
            case "clam":
                pizza = new ClamPizza(ingredientFactory);
                pizza.SetName("NY style clams pizza");
                break;
            default:
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.SetName("NY style pepperoni pizza");
                break;
        }

        return pizza;
    }

}