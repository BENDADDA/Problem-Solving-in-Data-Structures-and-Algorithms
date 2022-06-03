using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DynamicArray;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.SetWindowSize(160,57);
            
            star:
            Console.WriteLine("C/C#/C++");
            DynamicArray<int> table1=new DynamicArray<int>();
            int n;
            Console.Write("n=");
            int.TryParse(Console.ReadLine(), out n);
            for (int i = 0; i < n; i++)
            {
                table1.Set(i + 1);   
            }
           
           
            Console.WriteLine("Size:=" + table1.GetSize());
            int j = 0;
            board:
            string str;
            
            str=Console.ReadLine();
            
            switch (str)
            {
                case "EXIT": break;
                case "NEW STAR": Console.Clear();Console.Beep(); goto star; break;
                case"STAR":goto star;break;
                case "REMOVE": Console.Write("index:="); table1.Remove(int.Parse(Console.ReadLine()));
                    goto board; break;
                case "GETSIZE": Console.WriteLine(table1.GetSize());goto board;break;
                case "ADD": Console.Write("Enter the element:"); table1.Set(int.Parse(Console.ReadLine())); goto board; break;
                case "PRINT": Console.Write("----------------------\n");
                    table1.print();
                    str = ""; goto board; break;
                default: Console.Write("INCORRECT COMMANDS\n");
                    if (j == 3) { Console.Clear();  Console.Beep(); j = -1; }
                    j++;if(!(j==0)) Console.Beep(200,200); goto board; break;
            }
           
          
           
        }
    }
}
