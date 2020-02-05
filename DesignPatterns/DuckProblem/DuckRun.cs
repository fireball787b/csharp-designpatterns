using DesignPatterns.DuckProblem.Behaviour.Fly;
using DesignPatterns.DuckProblem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DuckProblem
{
    class DuckRun
    {
        public DuckRun() { }

        public void Test()
        {
            Duck mallardDuck = new MallardDuck();
            mallardDuck.PerformFly();
            mallardDuck.PerformQuack();

            Duck rubberDuck = new RubberDuck();
            rubberDuck.PerformFly();
            rubberDuck.PerformQuack();

            Duck disabledDuck = new DisabledDuck();
            disabledDuck.PerformFly();
            disabledDuck.PerformQuack();
            disabledDuck.SetFlyBehaviour(new FlyRocketPowered());
            disabledDuck.PerformFly();
        }
    }
}
