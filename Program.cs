using System;
using System.Net.Http.Headers;

namespace practice_lecture10
{

    class Program
    {

        static void Main(string[] args)
        {
            Motorcycle[] arrayInput = new Motorcycle[3];

           
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Input ID");
                int ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Input Model");
                string model = Console.ReadLine();
                Console.WriteLine("Input Manufacture");
                string manufacture = Console.ReadLine();
                Console.WriteLine("Input mileage");
                int mileage = int.Parse(Console.ReadLine());
                Console.WriteLine("Input volume");
                int volume = int.Parse(Console.ReadLine());
                Console.WriteLine("Input power");
                int power = int.Parse(Console.ReadLine());

                Motorcycle moto = new Motorcycle(ID, model, manufacture, new Motorcycle.Engine(volume, power) );
                arrayInput[i] = moto;
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arrayInput[i].toString());
            }


        }
    }
}
