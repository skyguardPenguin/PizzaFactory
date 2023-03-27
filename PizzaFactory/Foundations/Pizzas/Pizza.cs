using Newtonsoft.Json;
using PizzaFactory.Foundations.Ingredients;
using PizzaFactory.Foundations.Ingredients.Cheeses;
using PizzaFactory.Foundations.Ingredients.Clams;
using PizzaFactory.Foundations.Ingredients.Doughs;
using PizzaFactory.Foundations.Ingredients.Pepperonies;
using PizzaFactory.Foundations.Ingredients.Sauces;
using PizzaFactory.Foundations.Ingredients.Veggies;
using PizzaFactory.Tools;

namespace PizzaFactory.Foundations.Pizzas;

public abstract class Pizza
{
    protected string _name;
    protected IDough _dough;
    protected ISauce _sauce;
    protected List<IVeggies> _veggies;
    protected ICheese _cheese;
    protected IPepperoni _pepperoni;
    protected IClams _clams;



    public abstract void Prepare(); 
    public void Bake() => CustomWritter.WriteLine($"Bake {_name} for 25 minutes at 350",ConsoleColor.Green);
    
    public void Cut() =>CustomWritter.WriteLine($"Cutting the {_name} into diagonal slices", ConsoleColor.Green);
    
    public void Box() => CustomWritter.WriteLine($"Place {_name} in official PizzaStore box", ConsoleColor.Green);
    
    public void SetName(string name) =>_name = name;
    

    public override string ToString() => JsonConvert.SerializeObject(this);
    


}