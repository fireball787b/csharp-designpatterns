using System;
namespace DesignPatterns.FactoryPattern.Book.Models.Abstract
{
    public abstract class PizzaStore
    {
        virtual public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract Pizza CreatePizza(string type);
    }
}
