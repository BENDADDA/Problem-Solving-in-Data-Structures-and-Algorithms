using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class ClassDemo
    {
        static int Main2(string[] args)
        {
            CircleData<int> queue = new CircleData<int>(4);
            
            Console.WriteLine(queue.Dequeue());
           

          
            Console.ReadKey();
            return 0;
        }
    }
}
