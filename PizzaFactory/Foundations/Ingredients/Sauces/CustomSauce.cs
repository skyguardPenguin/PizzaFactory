namespace PizzaFactory.Foundations.Ingredients.Sauces;

public class CustomSauce:ISauce
{
    private string _name = nameof(CustomSauce);
    public string GetName() => _name;
}