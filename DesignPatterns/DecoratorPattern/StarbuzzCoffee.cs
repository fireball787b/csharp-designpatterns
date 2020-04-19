using System;
using DesignPatterns.DecoratorPattern.Book.Models;
using DesignPatterns.DecoratorPattern.Book.Models.Abstract;
using DesignPatterns.DecoratorPattern.Book.Models.Decorators;

namespace DesignPatterns.DecoratorPattern
{
    public class StarbuzzCoffee
    {
        //from the book
        private Beverage espresso;
        private Beverage houseBlend;

        public StarbuzzCoffee()
        {
            espresso = new Espresso();
            espresso.SetSize(Beverage.Size.VENTI);

            houseBlend = new HouseBlend();
        }

        public void Test()
        {
            espresso = new Mocha(espresso);
            espresso = new Mocha(espresso);
            espresso = new Whip(espresso);

            Console.WriteLine(espresso.GetDescription() + ", $" + espresso.GetCost());

            houseBlend = new Soy(houseBlend);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Whip(houseBlend);

            Console.WriteLine(houseBlend.GetDescription() + ", $" + houseBlend.GetCost());
        }
    }
}
