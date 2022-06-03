using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class ClassDemo3
    {
        static void Main4(string[] args)
        {
            DynamicArray<char> table = new DynamicArray<char>();
            table.Set('g');
            table.Set('h');
            table.Set('p');
            table.Set('t');
            table.Set('f');
            Console.WriteLine(table.Search('p'));
            Console.ReadKey();
            
           
        }
    }
}
