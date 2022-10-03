using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo
{
    class Collections
    {
      public void CollectionsDemo()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add("Ajay");
           
            foreach(var x in list)
                Console.WriteLine(x);
            list.Insert(1, 1000);
            Console.WriteLine("After Insertion");
            foreach (int x in list)
                Console.WriteLine(x);

            list.RemoveAt(0);
            Console.WriteLine("After Deletion");
            foreach (int x in list)
                Console.WriteLine(x);

            // Queue
            // FCFS
            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);
            Console.WriteLine("Elemenets of Queue");
            foreach (int x in queue)
                Console.WriteLine(x);

            queue.Dequeue();
            Console.WriteLine("Elemenets of Queue after Deletion");
            foreach (int x in queue)
                Console.WriteLine(x);


            // Stack 
            // LIFO

            Stack stack = new Stack();
            stack.Push(1000);
            stack.Push(2000);
            stack.Push(3000);


            Console.WriteLine("Elemenets of Stack");
            foreach (int x in stack)
                Console.WriteLine(x);

            stack.Pop();
            Console.WriteLine("Elemenets of Stack after Deletion");
            foreach (int x in stack)
                Console.WriteLine(x);

            
            // Key-value
            // Random Search of Values
            Hashtable ht = new Hashtable();
            ht["Ajay"] = 100;
            ht["Deepak"] = 20;
            ht["Sagar"] = 90;


            Console.WriteLine("Marks are " + ht["Deepak"]);

            foreach(string key in ht.Keys)
            {
                Console.WriteLine($"Marks of {key} are {ht[key]}");
            }









        }
    }
}
