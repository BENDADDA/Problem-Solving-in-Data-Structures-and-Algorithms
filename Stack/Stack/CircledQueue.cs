using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class CircledQueue<T>
    {
        Object[] Data;
        int size = 0;
        int Front;
        int Rear;
        public CircledQueue(int size)
        {
            this.size = size;
            Data = new Object[size];
            Front = -1;
            Rear = -1;
        }
        public void Queue(T element)
        {

            if (Rear + 1 == size)
            {
                if (Data[0]==null) Rear = -1;
                else return;
            }
            if (Data[Rear + 1] != null) return;
            Data[++Rear] = element;
            if (Front == -1) Front = 0;
        }
        public T Dequeue()
        {
            if (Front == -1) return default(T);
            Object x = Data[Front];
            Data[Front++] = null;
            if (Rear < Front)
            {
                if (Data[Rear] == null) Front = Rear = -1;
                else if (Front + 1 == size) Front = 0;
                
            }
            return (T)x;
        }

        int f(int n)
        {
            int a = n / size;
            if (n < size) return n;
            return n - a * size;

        }


    }
}
