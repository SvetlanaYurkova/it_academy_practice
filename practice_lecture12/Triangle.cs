using System;
using System.Collections.Generic;
using System.Text;

namespace practice_lecture12
{
    class Triangle : Shape
    {
        private int heigth;
        public Triangle(int heigth)
        {
            this.heigth = heigth;
        }

        public override double GetArea()
        {
            return Math.Sqrt(3.0) / 4.0 * heigth * heigth;
        }
        public override void GetInfo()
        {
            Console.WriteLine("This is triangle. CLR Type is " + this.GetType() + ". Square is " + this.GetArea());
        }
    }
}
