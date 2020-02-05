using DesignPatterns.DuckProblem.Interface;
using System;

namespace DesignPatterns.DuckProblem.Behaviour.Quack
{
    class Quack : QuackBehaviour
    {
        public void QuackALot()
        {
            Console.WriteLine("I can quack!!!");
        }
    }
}
