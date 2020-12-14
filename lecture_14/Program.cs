using System;

namespace lecture_14
{
    class Program
    {
        struct Rectangle 
        {
            public int height;
            public int width;

            public Rectangle(int height, int width)
            {
                this.width = width;
                this.height = height;
            }
        }
        static void Main(string[] args)
        {
            int Min = 0;
            int Max = 10;

            Rectangle[] rectangles = new Rectangle[100];

            Random rand = new Random();
            for (int i = 0; i < rectangles.Length; i++)
            {
                rectangles[i] = new Rectangle(rand.Next(Min, Max), rand.Next(Min, Max));
            }

            Rectangle refRectangle = rectangles[0];
            int counter = 0;

            for (int i = 1; i < rectangles.Length; i++)
            {
                if (refRectangle.Equals(rectangles[i]))
                {
                    counter++;
                }
            }

            for (int i = 0; i < rectangles.Length; i++)
            {
                Console.WriteLine("Rectangle {0} : width = {1}, height = {2}", i, rectangles[i].width, rectangles[i].height);
            }

            Console.WriteLine("Counter = " + counter);
        }
    }
}
