using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodDay
{
  class Greeting
  {
    public void print()
    {
      DateTime dtNow = DateTime.Now;
      int hourNow = dtNow.Hour;
      if (hourNow >= 9 && hourNow <= 12)
        Console.WriteLine("Good morning, guys");
      else if (hourNow >= 12 && hourNow <= 15)
        Console.WriteLine("Good day, guys");
      else if (hourNow >= 15 && hourNow <= 22)
        Console.WriteLine("Good evening, guys");
      else Console.WriteLine("Good night, guys");
    }
  }
}
