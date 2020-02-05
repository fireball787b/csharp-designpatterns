using DesignPatterns.DuckProblem.Interface;

namespace DesignPatterns.DuckProblem.Models
{
    abstract class Duck
    {
        public FlyBehaviour flyBehaviour;
        public QuackBehaviour quackBehaviour;

        public Duck()
        {
        }

        public void PerformFly()
        {
            flyBehaviour.Fly();
        }

        public void PerformQuack()
        {
            quackBehaviour.QuackALot();
        }

        public void SetFlyBehaviour(FlyBehaviour behaviour)
        {
            flyBehaviour = behaviour;
        }

        public void SetQuakBehaviour(QuackBehaviour behaviour)
        {
            quackBehaviour = behaviour;
        }
    }
}
