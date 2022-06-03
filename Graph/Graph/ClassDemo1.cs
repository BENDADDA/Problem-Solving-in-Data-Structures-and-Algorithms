using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    class ClassDemo1
    {
        static void Main2()
        {
            Vertice n1 = new Vertice(1, 6, 10);
            Vertice n2 = new Vertice(2, 6, 20);
            Vertice n3 = new Vertice(3, 6, 30);
            Vertice n4 = new Vertice(4, 6, 40);
            Vertice[] array = new Vertice[] { n1, n2,n3,n4 };
            PriorityQueue<Vertice> heap = new PriorityQueue<Vertice>(array);
            
          
            
            while (!heap.IsEmpty())
            {
                Vertice node = heap.Dequeue();
                Console.WriteLine(node);
            }
            Console.ReadLine();
        }
    
    }
}
