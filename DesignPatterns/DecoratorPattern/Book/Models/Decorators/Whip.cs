using System;
using DesignPatterns.DecoratorPattern.Book.Models.Abstract;

namespace DesignPatterns.DecoratorPattern.Book.Models.Decorators
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage _beverage)
        {
            beverage = _beverage;
        }

        public override double GetCost()
        {
            double cost = beverage.GetCost();
            if (beverage.GetSize() == Size.TALL)
                cost += 0.00;
            if (beverage.GetSize() == Size.GRANDE)
                cost += 0.10;
            if (beverage.GetSize() == Size.VENTI)
                cost += 0.15;
            return cost;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }
    }
}
