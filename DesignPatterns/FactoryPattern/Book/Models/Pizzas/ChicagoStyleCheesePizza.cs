using System;
using DesignPatterns.FactoryPattern.Book.Models.Abstract;

namespace DesignPatterns.FactoryPattern.Book.Models.Pizzas
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago style deep dish cheese pizza";
            dough = "Extra thick crust dough";
            sauce = "Plum tomato sauce";

            toppings.Add("Shredded");
            toppings.Add("Mozzarella");
            toppings.Add("Cheese");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
