using PizzaFactory.Foundations.Ingredients.Cheeses;
using PizzaFactory.Foundations.Ingredients.Clams;
using PizzaFactory.Foundations.Ingredients.Doughs;
using PizzaFactory.Foundations.Ingredients.Pepperonies;
using PizzaFactory.Foundations.Ingredients.Sauces;
using PizzaFactory.Foundations.Ingredients.Veggies;

namespace PizzaFactory.Foundations.IngredientFactories;

public class NYPizzaIngredientFactory:IPizzaIngredientFactory
{
    public ICheese CreateCheese() => new MonterreyCheese();
    public IClams CreateClam() => new CustomClam();
    public IDough CreateDough() => new CustomDough();
    public IPepperoni CreatePepperoni() => new CustomPepperoni();
    public ISauce CreateSauce() => new BlackSauce();
    public  List<IVeggies>CreateVeggies ()=> new () { new Onion() };

}