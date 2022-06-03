using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class ClassDemo4
    {
        static void Main545()
        {
            DoubleLinkList<int> list = new DoubleLinkList<int>();
            list.Add(4);
            list.Add(5);
            list.Add(7);
            list.Add(9);
            list.Add(45);
            list.Addlast(1);
            list.Addlast(0);
            Console.WriteLine();
            list.Print();
            list.Reverse();
            Console.WriteLine();
            list.Print();
            Console.ReadKey();
        }
    }
}
