using System;
using System.Collections;

namespace lecture_14_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(45); //boxing
            arrayList.Add(true); //boxing
            arrayList.Add("Hello!"); 
            arrayList.Add(23.45); //boxing

            foreach (var item in arrayList)
            {
                Console.WriteLine(item.GetType());
            }
        }
    }
}
