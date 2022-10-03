using System;
 
namespace DummyProject
{
    class File4
    {
        static void Main()
        {
            // Sequential
            int num1, num2;
            Console.WriteLine("Enter value of num1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2} ");
            Console.WriteLine($"Difference of {num1} and {num2} is {num1 - num2} ");
            Console.WriteLine($"Product of {num1} and {num2} is {num1 * num2} ");
            Console.WriteLine($"Quotient of {num1} and {num2} is {num1 / num2} ");
            Console.WriteLine($"Remainder of {num1} and {num2} is {num1 % num2} ");

        }
    }
}
