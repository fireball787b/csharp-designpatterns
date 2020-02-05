using DesignPatterns.DuckProblem.Behaviour;
using DesignPatterns.DuckProblem.Behaviour.Quack;

namespace DesignPatterns.DuckProblem.Models
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new Squeak();
        }
    }
}
