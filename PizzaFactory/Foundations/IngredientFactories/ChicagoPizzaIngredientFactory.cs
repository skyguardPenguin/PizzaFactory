using PizzaFactory.Foundations.Ingredients.Cheeses;
using PizzaFactory.Foundations.Ingredients.Clams;
using PizzaFactory.Foundations.Ingredients.Doughs;
using PizzaFactory.Foundations.Ingredients.Pepperonies;
using PizzaFactory.Foundations.Ingredients.Sauces;
using PizzaFactory.Foundations.Ingredients.Veggies;

namespace PizzaFactory.Foundations.IngredientFactories;

public class ChicagoPizzaIngredientFactory:IPizzaIngredientFactory
{
    public ICheese CreateCheese() => new MozzarelaCheese();
    public IClams CreateClam() => new FrozenClams();
    public IDough CreateDough() => new ThickCrustDough();
    public IPepperoni CreatePepperoni() => new YellowPepperoni();
    public ISauce CreateSauce() => new CustomSauce();
    public  List<IVeggies>CreateVeggies ()=> new () { new Mushroom() };
}