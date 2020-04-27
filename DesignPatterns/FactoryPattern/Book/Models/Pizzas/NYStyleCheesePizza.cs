using DesignPatterns.FactoryPattern.Book.Models.Abstract;

namespace DesignPatterns.FactoryPattern.Book.Models.Pizzas
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY style sauce and cheese pizza";
            dough = "Thin crust dough";
            sauce = "Marinara sauce";

            toppings.Add("Grated");
            toppings.Add("Reggiano");
            toppings.Add("Cheese");
        }
    }
}
