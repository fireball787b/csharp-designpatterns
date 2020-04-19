using DesignPatterns.DecoratorPattern.Book.Models.Abstract;

namespace DesignPatterns.DecoratorPattern.Book.Models.Decorators
{
    public class Mocha : CondimentDecorator
    {

        public Mocha(Beverage _beverage)
        {
            beverage = _beverage;
        }

        public override double GetCost()
        {
            double cost = beverage.GetCost();
            if (beverage.GetSize() == Size.TALL)
                cost += 0.10;
            if (beverage.GetSize() == Size.GRANDE)
                cost += 0.15;
            if (beverage.GetSize() == Size.VENTI)
                cost += 0.20;
            return cost;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }
    }
}
