
using PizzaFactory.Foundations.PizzaStores;
using PizzaFactory.Tools;

PizzaStore nyStore = new NYPizzaStore();
CustomWritter.WriteLine("\nOrdering cheese pizza in New York style...", ConsoleColor.Cyan);
nyStore.OrderPizza("cheese");
CustomWritter.WriteLine("\nOrdering veggie pizza in New York style...", ConsoleColor.Cyan);
nyStore.OrderPizza("veggie");

CustomWritter.WriteLine("\nChanging to chicago style...", ConsoleColor.Cyan);

nyStore = new ChicagoPizzaStore();
CustomWritter.WriteLine("\nOrdering cheese pizza in Chicago style...", ConsoleColor.Cyan);
nyStore.OrderPizza("cheese");
CustomWritter.WriteLine("\nOrdering pepperoni pizza in Chicago style...", ConsoleColor.Cyan);
nyStore.OrderPizza("pepperoni");

