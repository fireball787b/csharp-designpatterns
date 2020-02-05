using DesignPatterns.DuckProblem.Behaviour;
using DesignPatterns.DuckProblem.Behaviour.Quack;

namespace DesignPatterns.DuckProblem.Models
{
    class DisabledDuck : Duck
    {
        public DisabledDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new Quack();
        }
    }
}
