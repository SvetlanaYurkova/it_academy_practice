using System;
using System.Collections.Generic;
using System.Text;

namespace practice_lecture12
{
    class Square: Shape
    {
        private int Side;

        public Square(int Side)
        {
            this.Side = Side;
        }

        public override double GetArea()
        {
            return Side*2;
        }
        public override void GetInfo()
        {
            Console.WriteLine("This is square. CLR Type is " + this.GetType() + ". Square is " + this.GetArea());
        }
    }
}
