using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    class Program
    {
        static void Main1(string[] args)
        {

            int[,] Matrix = new int[,]{
                    //0 1 2 3 4 5
                /*0*/{0,2,0,0,9,5},
                /*1*/{2,0,8,9,2,6},
                /*2*/{0,8,0,1,0,3},
                /*3*/{0,9,1,0,7,0},
                /*4*/{9,2,0,7,0,4},
                /*5*/{5,6,3,0,4,0},
            };
            
            Graph graph = new Graph(6);
            graph.Matrix(Matrix);
            Console.WriteLine("Adjacency List:\n");
            graph.Print();
            Console.ReadLine();
            
        }
    }
}
