using DesignPatterns.DuckProblem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DuckProblem.Behaviour.Quack
{
    class Squeak : QuackBehaviour
    {
        public void QuackALot()
        {
            Console.WriteLine("I can squeak!!!");
        }
    }
}
