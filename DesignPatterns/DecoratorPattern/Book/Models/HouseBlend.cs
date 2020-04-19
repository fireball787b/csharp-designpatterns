using DesignPatterns.DecoratorPattern.Book.Models.Abstract;

namespace DesignPatterns.DecoratorPattern.Book.Models
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House blend coffee";
        }

        public override double GetCost()
        {
            return 0.89;
        }
    }
}
