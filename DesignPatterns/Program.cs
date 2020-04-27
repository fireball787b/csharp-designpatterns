using DesignPatterns.DecoratorPattern;
using DesignPatterns.DuckProblem;
using DesignPatterns.FactoryPattern.Book;
using DesignPatterns.ObserverPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //DuckProblem
            //DuckRun duckrun = new DuckRun();
            //duckrun.Test();

            //ObserverPattern
            //WeatherStation weatherStation = new WeatherStation();
            //weatherStation.Test();

            //DecoratorPAttern
            //StarbuzzCoffee starbuzzCoffee = new StarbuzzCoffee();
            //starbuzzCoffee.Test();

            //FactoryPattern
            OrderPizzaManager orderPizzaManager = new OrderPizzaManager();
            orderPizzaManager.Test();
        }
    }
}
