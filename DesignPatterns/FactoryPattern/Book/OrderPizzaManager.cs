using System;
using DesignPatterns.FactoryPattern.Book.Models.Abstract;
using DesignPatterns.FactoryPattern.Book.Models.Stores;

namespace DesignPatterns.FactoryPattern.Book
{
    public class OrderPizzaManager
    {
        public OrderPizzaManager()
        {
        }

        public void Test()
        {
            PizzaStore nyStore = new NYPizzaStore();
            ChicagoPizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine(pizza.GetName());

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine(pizza.GetName());
        }
    }
}
