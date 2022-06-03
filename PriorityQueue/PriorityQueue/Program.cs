using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            PriorityQueue<string> queue = new PriorityQueue<string>();
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("V{0}=", i);
                String value = Console.ReadLine();
                queue.Enqueue(value);
            }
           
        r:
            Console.WriteLine("Min:" +queue.Dequeue());
            Console.ReadLine();

            goto r;
        }
    }
}
