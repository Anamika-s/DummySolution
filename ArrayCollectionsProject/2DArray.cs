using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayCollectionsProject
{
    class TwoDArray
    {
        public void Two_DArray()
        {
            int[,] num = new int[3, 3];
            Console.WriteLine("Entr elements");
            for(int i=0;i<3;i++)
            {
                 for(int j=0;j<3;j++)

                {
                    num[i, j] = Byte.Parse(Console.ReadLine());
                }          
            }
            Console.WriteLine("Elements are");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)

                {
                    Console.Write(num[i,j] +  " " );
                }
            }

        }
    }
}
