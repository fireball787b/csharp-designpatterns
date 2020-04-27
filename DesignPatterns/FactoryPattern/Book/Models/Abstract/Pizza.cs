using System;
using System.Collections.Generic;

namespace DesignPatterns.FactoryPattern.Book.Models.Abstract
{
    public abstract class Pizza
    {
        public string name { get; set; }
        public string dough { get; set; }
        public string sauce { get; set; }

        public List<string> toppings { get; set; } = new List<string>();

        public void Prepare()
        {

            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing " + dough);
            Console.WriteLine("Adding sauce " + name);
            Console.WriteLine("Adding toppings: ");

            foreach (string topping in toppings)
                Console.WriteLine(" " + topping);
        }

        virtual public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        virtual public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        virtual public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        virtual public string GetName()
        {
            return name;
        }
    }
    
}
