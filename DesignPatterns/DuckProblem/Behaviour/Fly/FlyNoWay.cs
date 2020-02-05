using DesignPatterns.DuckProblem.Interface;
using System;

namespace DesignPatterns.DuckProblem.Behaviour
{
    class FlyNoWay : FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I can not fly!!!");
        }
    }
}
