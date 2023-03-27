namespace PizzaFactory.Foundations.Ingredients.Sauces;

public class BlackSauce:ISauce
{
    private string _name= nameof( BlackSauce);
    public string GetName() => _name;
}