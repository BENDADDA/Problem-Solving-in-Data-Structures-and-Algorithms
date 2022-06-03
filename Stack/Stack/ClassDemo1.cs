using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class ClassDemo1
    {
        static int Main3(string[] args)
        {

            LinkedListQueue<int> queue = new LinkedListQueue<int>();
            queue.Queue(5);
            queue.Clear();
            queue.Queue(7);
            queue.Clear();
            queue.Queue(9);
           
            Console.WriteLine(queue.DeQueue());
            Console.WriteLine("size="+queue.GetSize());
            Console.WriteLine(queue.DeQueue());
            Console.WriteLine("size=" + queue.GetSize());
            Console.WriteLine(queue.DeQueue());
            Console.WriteLine("size=" + queue.GetSize());
            Console.ReadKey();
            return 0;
        }
    }
}
