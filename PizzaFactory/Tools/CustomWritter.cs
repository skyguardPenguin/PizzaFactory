namespace PizzaFactory.Tools;

public static class CustomWritter
{
    public static void WriteLine(string text, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(text);
        Console.ForegroundColor = ConsoleColor.White;

    }
}