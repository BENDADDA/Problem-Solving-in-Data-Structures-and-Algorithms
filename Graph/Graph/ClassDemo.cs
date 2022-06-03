using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    class ClassDemo
    {
        static void Main(string[] args)
        {

            int[,] Matrix = new int[,]{
                    //  0  1  2  3  4  5  6  7
                 /*0*/{00,09,15,14,00,00,00,00},
                 /*1*/{09,00,00,00,00,00,00,24},
                 /*2*/{15,00,00,05,20,44,00,00},
                 /*3*/{14,00,05,00,30,00,00,18},
                 /*4*/{00,00,20,30,00,16,11,02},
                 /*5*/{00,00,44,00,16,00,06,19},
                 /*6*/{00,00,00,00,11,06,00,06},
                 /*7*/{00,24,00,18,02,19,06,00},
               
            };

            Graph graph = new Graph(8);
            graph.Matrix(Matrix);
            Console.WriteLine("Representation whith Adjacency list\n");
            graph.Print();
            Console.WriteLine("Prim's Algorithms:\n");
            graph.Prim(0);
            Console.WriteLine("\nKruskal's Algorithms:\n");
            graph.Kruskal();
            Console.WriteLine("\nDijkstra's Algorithms:\n");
            graph.Dijkstar(5);
            
            Console.ReadLine();

        }

    }
}
