using System;
using System.Collections.Generic;
using System.Text;

namespace practice_lecture12
{
    class Circle:Shape
    {
        private int Radius;
        public Circle(int Radius)
        {
            this.Radius = Radius;
        }
        public override double GetArea()
        {
            return 2 * Math.PI * Radius;
        }

        public override void GetInfo()
        {
            Console.WriteLine("This is circle. CLR Type is " + this.GetType() + ". Square is " + this.GetArea());
        }

    }
}
