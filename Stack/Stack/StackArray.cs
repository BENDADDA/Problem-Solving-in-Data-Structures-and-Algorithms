using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class StackArray<T>
    {
        Object []Data;
        public int Size;
        public int Top;
        public StackArray(int Size)
        {
            Data=new Object[Size];
            this.Size=Size;
            Top = -1;
        }
        public void Push(T element)
        {
            if (Size == Top + 1) return;// the stack is full
            Data[++Top] = element;
        }
        public T Pop()
        {
            if (Top == -1) return default(T);//the stack is empty
            Object x = Data[Top];
            Data[Top--] = null;
            return (T)x;
        }
        
        
      

    }
}
