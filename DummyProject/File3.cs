using System;
using System.Collections.Generic;
using System.Text;

namespace DummyProject
{
    class File3
    {
        static void Main()
        {
            // Declare & Initialize Variables 
            int num1 = 10, num2 = 20;
            Console.WriteLine("Sum of num1 and num2 is " + (num1+ num2));
            Console.WriteLine("Sum of " +  num1 + " and " +  num2  + " is " + (num1 + num2));
          // Postional Parameters
            Console.WriteLine("Sum of  {0} and  {1}   is {2} " , num1 ,num2 , (num1+num2));
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2} ");
        }
    }
}
