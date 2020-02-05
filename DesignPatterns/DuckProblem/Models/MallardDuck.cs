using DesignPatterns.DuckProblem.Behaviour;
using DesignPatterns.DuckProblem.Behaviour.Quack;

namespace DesignPatterns.DuckProblem.Models
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehaviour = new Quack();
            flyBehaviour = new FlyWithWings();
        }
    }
}
