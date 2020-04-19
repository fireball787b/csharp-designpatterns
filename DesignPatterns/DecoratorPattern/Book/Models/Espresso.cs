using DesignPatterns.DecoratorPattern.Book.Models.Abstract;

namespace DesignPatterns.DecoratorPattern.Book.Models
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double GetCost()
        {
            return 1.99;
        }
    }
}
