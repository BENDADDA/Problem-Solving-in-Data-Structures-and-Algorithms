using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class Program
    {
        static void Main1(string[] args)
        {
            StackLinkList<int> stack = new StackLinkList<int>();
            stack.Push(5);
            stack.Push(3);
            stack.Push(99);
            
         
            Console.WriteLine(stack.Pop());

            Console.ReadKey();
        }
    }
}
