using DataLibrary;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            Console.WriteLine($"{espresso.Description} ${espresso.Cost()}");

            List<Beverage> darkRoastList = new List<Beverage>();
            Beverage darkRoast = new DarkRoast();
            darkRoast = new MochaDecorator(darkRoast);
            darkRoast = new WhipDecorator(darkRoast);
            Console.WriteLine($"{darkRoast.Description} ${darkRoast.Cost().ToString("F")}");

        }
    }
}