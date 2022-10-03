using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayCollectionsProject
{
    class JaggedArray
    {
        public void Jagged_Array()
        {
            int[][] marks = new int[10][];
            Console.WriteLine("Enter Marks of Student 1");
            marks[0] = new int[2];
            marks[0][0] = Byte.Parse(Console.ReadLine()) ;
            marks[0][1] = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks of Student 2");
            marks[1] = new int[3];
            marks[1][0] = Byte.Parse(Console.ReadLine());
            marks[1][1] = Byte.Parse(Console.ReadLine());
            marks[1][2] = Byte.Parse(Console.ReadLine());



        }

    }
}
