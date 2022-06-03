using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Binary_Search
{
    class Program
    {
        static int ntry=0;
        static bool BinarySearch(int []v,int element,int low,int high)
        {
            int mid;
            while(low<=high)
            {
                ntry++;
                mid=(low+high)/2;
                if(v[mid]==element){ return true;break;}
                else
                {
                    if (v[mid] < element) low = mid + 1;
                    else high = mid- 1;
                }
            
            }
            return false;
        }
        static bool InterpolationSearch(int[] v, int element, int low, int high)
        {
            int mid;
            while (low <= high)
            {
                ntry++;
                mid = low + (high - low) / (v[high] - v[low]) * (element - v[0]);
                if (v[mid] == element) { return true; break; }
                else
                {
                    if (v[mid] < element) low = mid + 1;
                    else high = mid - 1;
                }

            }
            return false;
        }
        static bool SequenceSearch(int[] U, int element)
        {
            int n = U.Length - 1;
            int m = (element - U[0]) * n / (U[n] - U[0]);
            if (m>=0&&U[m] == element) return true;
            return false;
        }
        static void Main(string[] args)
        {
            int n =5954545;
            int s = 0;
            int[] table = new int[n] ;
            for (int i = 0; i < n; i++)
            {
                table[i] = 4*i;
                
            }

           bool r =BinarySearch(table,n-1,0,n-1);
            Console.WriteLine("m:"+r+"\ntry="+ntry);
            Console.ReadKey();
        }
    }
}
