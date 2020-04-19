using System;
using DesignPatterns.DecoratorPattern.Book.Models.Abstract;

namespace DesignPatterns.DecoratorPattern.Book.Models.Decorators
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage _beverage)
        {
            beverage = _beverage;
        }

        public override double GetCost()
        {
            double cost = beverage.GetCost();
            if (beverage.GetSize() == Size.TALL)
                cost += 0.20;
            if (beverage.GetSize() == Size.GRANDE)
                cost += 0.30;
            if (beverage.GetSize() == Size.VENTI)
                cost += 0.40;
            return cost;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }
    }
}
