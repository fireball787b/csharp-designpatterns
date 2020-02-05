using DesignPatterns.DuckProblem.Interface;
using System;

namespace DesignPatterns.DuckProblem.Behaviour.Quack
{
    class MuteQuack : QuackBehaviour
    {
        public void QuackALot()
        {
            //do nothing - can't quack
            Console.WriteLine("I can not quack!!!");
        }
    }
}
