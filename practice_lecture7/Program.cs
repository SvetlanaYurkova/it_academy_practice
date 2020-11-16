using System;

namespace practice_lecture7
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] array = CreateArray();
            ChangeArray();
 
        }

        private static int[] CreateArray() {
            return new int[5];
        }

        static void ChangeArray()
        {
            Object[] ArrayOfObjects = new Object[] { 23, 'A', "Hello" };
            for (int i = 0; i < ArrayOfObjects.Length; i++)
            {
                Console.WriteLine(ArrayOfObjects[i]);
            }

            ArrayOfObjects[0] = (int)ArrayOfObjects[0] + 10;
            ArrayOfObjects[2] = ArrayOfObjects[2]  + ", guys!";

            for (int i = 0; i < ArrayOfObjects.Length; i++)
            {
                Console.WriteLine(ArrayOfObjects[i]);
            }
        }

    }
}
