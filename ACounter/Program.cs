using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACounter
{
  class Program
  {
    static void Main(string[] args)
    {
      string str = Console.ReadLine();
      int len = 0;
      int counter = 0;
      if (str != null)
      {
        len = str.Length;
        for (int i = 0; i < len; i++)
        {
          if (str[i] == 'a') counter += 1;
        }
      }
      Console.WriteLine("found " + counter + " a");
    }
  }
}
