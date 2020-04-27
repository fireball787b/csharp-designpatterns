using DesignPatterns.FactoryPattern.Book.Models.Abstract;
using DesignPatterns.FactoryPattern.Book.Models.Pizzas;

namespace DesignPatterns.FactoryPattern.Book.Models.Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese"))
                return new ChicagoStyleCheesePizza();
            else
                return null;
        }
    }
}
