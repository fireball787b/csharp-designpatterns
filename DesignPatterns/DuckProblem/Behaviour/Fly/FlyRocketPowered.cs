using DesignPatterns.DuckProblem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DuckProblem.Behaviour.Fly
{
    class FlyRocketPowered : FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I am flying with a rocket!!!");
        }
    }
}
