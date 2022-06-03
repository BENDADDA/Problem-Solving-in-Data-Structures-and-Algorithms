using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Stack
{
    public class DynamicArray<T>
    {
        T[] data;
        int size;
     
        public DynamicArray()
        {
            size = 0;
            data = new T[1];
        }
        public T Get(int index)
        {
            return data[index];
        }
        public void Set(T element)
        {
            int l = data.Length;
            if (size + 1 > l) data = CopyOf(data, l * 2);
            data[size++] = element;
     
        }
        //indexing arrays
        public T this[int i]
        {
            get
            {
                return data[i];
            }
            set
            {
                if (size > i) data[i] = value;//Edit.
                else if (size == i) Set(value);//Add.
            }

        }
        public int GetSize()
        {
            return data.Length;
        }

        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(data[i]);
                if (size < 6) Console.Beep(1000, 400);
            }
        }
        public void Remove(int index, int y = 1)
        {

            if (size * y == 0 || index >= size) return;
            for (int i = index + 1; i < size; i++)
            {
                data[i - 1] = data[i];
            }
            data[--size] = default(T);
            if (2 * size == data.Length) data = Copyof(data, size);
        }

        T[] CopyOf(T[] v, int l)
        {
            T[] table = new T[l];
            Array.Copy(v, table, v.Length);
            return table;
        }
        T[] Copyof(T[] v, int l)
        {
            T[] table = new T[l];
            for (int i = 0; i < v.Length; i++)
            {
                table[i] = v[i];
            }
            return table;
             
        }
         public bool Search (T element) // the comlexty is n.
         {
             for (int i = 0; i < size; i++)
                 if (trs(element) == trs(data[i])) return true;
             return false;
         }
         decimal trs(T elemet)
         {
             decimal e;
             try
             {
                 e = Convert.ToDecimal(elemet);
             }
             catch
             {
                 e = Convert.ToDecimal(Convert.ToInt32(elemet));
             }
             return e;
         }

    
    }
}
