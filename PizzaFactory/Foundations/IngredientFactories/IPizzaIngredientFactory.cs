using PizzaFactory.Foundations.Ingredients.Cheeses;
using PizzaFactory.Foundations.Ingredients.Clams;
using PizzaFactory.Foundations.Ingredients.Doughs;
using PizzaFactory.Foundations.Ingredients.Pepperonies;
using PizzaFactory.Foundations.Ingredients.Sauces;
using PizzaFactory.Foundations.Ingredients.Veggies;

namespace PizzaFactory.Foundations.IngredientFactories;

public interface IPizzaIngredientFactory
{
    public IDough CreateDough();
    public ISauce CreateSauce();
    public ICheese CreateCheese();
    public List<IVeggies> CreateVeggies();
    public IPepperoni CreatePepperoni();
    public IClams CreateClam();
}