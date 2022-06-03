using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            front:
       
                BinaryTree tree = new BinaryTree();
                Console.Write("n=");
              
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    try
                    {
                        tree.Add(int.Parse(Console.ReadLine()));
                    }
                    catch
                    {
                        i--;
                    }

                }
                Console.WriteLine("------------");
                tree.Display();
                tree.Remove(5);
                
                Console.WriteLine("\n------------");
                tree.Display();
                Console.WriteLine("\n");
                
        
             
            Console.ReadKey();
            Console.Clear();
            goto front;
        }
    }
}
