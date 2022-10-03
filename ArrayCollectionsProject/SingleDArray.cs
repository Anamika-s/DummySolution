using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayCollectionsProject
{
    class SingleDArray
    {
        public void SArray()
        {
            int[] num = new int[10];
            Console.WriteLine("Enter Elements");
            for (int i = 0; i < 10; i++)
            {
                num[i] = Convert.ToByte(Console.ReadLine());

            }
            //Console.WriteLine("Numbers are ");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}
            int sum=0;
            Console.WriteLine("Numbers are ");
            foreach (int x in num)
            {
                sum += x;
                Console.WriteLine(x);
            }
            float avg = (float)sum / 10;
            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Average is {avg}");
        }
    }
}
