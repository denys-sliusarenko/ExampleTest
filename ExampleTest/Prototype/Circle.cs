using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleTest.Prototype
{
    class Circle : IFigure
    {
        private int radius;
        public Circle(int r)
        {
            radius = r;
        }
        public IFigure Clone()
        {
            //return this.MemberwiseClone() as IFigure;
            return new Circle(this.radius);
        }

        public void GetInfo()
        {
            Console.WriteLine("Круг радиусом {0}", radius);
        }
    }
}
