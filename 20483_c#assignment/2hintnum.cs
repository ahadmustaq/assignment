using System;
using System.Collections.Generic;
using System.Text;

namespace sampleprogram
{
    class hintnum
    {
      public  static void Main()
        {
            Console.WriteLine("enter day");
            string day = Console.ReadLine();
            int n = int.Parse(day);
            if (n == 0 || n > 7)
            {
                Console.WriteLine("enter valid input ");
            }
            else if (n<6)
            {
                Console.WriteLine("working day");
            }
            else
                Console.WriteLine("holiday");
        }
    }
}

        
    
