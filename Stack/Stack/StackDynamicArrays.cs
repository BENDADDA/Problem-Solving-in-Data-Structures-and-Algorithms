using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class StackDynamicArrays<T>
    {
        DynamicArray<T> Data;
        public int Top;
        public StackDynamicArrays()
        {
            Data = new DynamicArray<T>();
            Top = -1;
        }
        public void Push(T element)
        {
            Data[++Top] = element;
        }
        public T Pop()
        {
            if (Top==-1) return default(T);//the stack is empty
            T x = Data[Top];
            Data.Remove(Top--);
            return x;
        }

    }
}
