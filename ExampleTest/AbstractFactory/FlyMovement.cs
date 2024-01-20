using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTest.AbstractFactory
{
    class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Летим!");
        }
    }
}
