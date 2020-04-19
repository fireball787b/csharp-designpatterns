namespace DesignPatterns.DecoratorPattern.Book.Models.Abstract
{
    public abstract class Beverage
    {
        public string description = "Unkown beverage";
        public enum Size { TALL, GRANDE, VENTI };
        public Size size = Size.TALL;

        //The virtual keyword is used to modify a method, property, indexer, or event declared in the base class and allow it to be overridden in the derived class.
        public virtual string GetDescription()
        {
            return description;
        }

        public void SetSize(Size _size)
        {
            size = _size;
        }

        public virtual Size GetSize()
        {
            return size;
        }

        public abstract double GetCost();
    }
}
