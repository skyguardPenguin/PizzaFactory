namespace PizzaFactory.Foundations.Ingredients.Doughs;

public class ThickCrustDough:IDough
{
    private string _name = nameof(ThickCrustDough);

    public string GetName() => _name;
}