namespace DesignPatterns.DecoratorPattern.Book.Models.Abstract
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;
        //The override keyword is used to extend or modify a VIRTUAL/abstract method, property, indexer, or event of base class into derived class.
        public override abstract string GetDescription();

        public override Size GetSize()
        {
            return beverage.GetSize();
        }
    }
}
