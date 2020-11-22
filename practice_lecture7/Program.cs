using System;
using System.Linq;

namespace practice_lecture7
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] array = CreateArray();
            ChangeArray();
            MaxValueFinder();
            BoxingUnboxing();
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

        static void MaxValueFinder() {
            Random random = new Random();

            int[] array = new int[13];

            for (int i = 0; i < 13; i++)
            {
                array[i] = random.Next(0, 10);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            int maxValue = array.Max();
            Console.WriteLine("Макимальное значение: " + maxValue);
        }

        static void BoxingUnboxing() {
            
            short short1 = 123;
            SByte  sbyte1 = (sbyte)short1;

            System.SByte asd = sbyte1;

            Console.WriteLine(asd + " " + asd.GetType());       
        }
    }
}
