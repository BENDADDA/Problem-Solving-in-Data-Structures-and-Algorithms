using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PriorityQueue
{
    class ClassDemo
    {
        static void Main1()
        {
            PriorityQueue<char> heap = new PriorityQueue<char>();

            string str = "Q,1/r7tSy3B@9`%-A5ZqWe.^&*(YbHvNcxUzJMIK8aDsd4fCg2hRjFkVlTGm_+=0OLP)uXi6oEpn";
            char []array = str.ToArray();
            heap.Sort(array,true);
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
           
            Console.ReadKey();

        }

    }
}