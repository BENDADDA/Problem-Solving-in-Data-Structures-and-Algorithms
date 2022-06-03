using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class ClassDemo5
    {
        static void Main()
        {
            CircularLindkedList<int> list =new CircularLindkedList<int>();     
            list.AddEnd(1);
            list.AddEnd(8);
            list.AddEnd(5);
            list.AddEnd(99);
            Console.WriteLine();
            list.Print();
            
            Console.ReadKey();
        }
    }
}
