using DesignPatterns.DuckProblem.Interface;
using System;

namespace DesignPatterns.DuckProblem.Behaviour
{
    class FlyWithWings : FlyBehaviour
    {
        public void Fly()
        {
            //implements duck flying
            Console.WriteLine("I can fly!!!");
        }
    }
}
