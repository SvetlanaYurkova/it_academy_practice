using System;

namespace practice_lecture12
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {new Square(2), new Circle(3), new Triangle(5), new Square(4), new Circle(2)};
            for (int i = 0; i < shapes.Length; i++)
            {
                shapes[i].GetInfo();
            }

        }
    }
}
