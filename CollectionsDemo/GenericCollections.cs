using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo
{
    class GenericCollections
    {
        public void GCollections()
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(20);

            foreach(int x in list)
                Console.WriteLine(x);

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Ajay");

            foreach(string temp in queue)
                Console.WriteLine(temp);

            Stack<float> stack = new Stack<float>();
            stack.Push(12.3f);

            Dictionary<string, int> marks = new Dictionary<string, int>();
            marks["Ajay"] = 10;

        }
    }
}
