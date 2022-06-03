using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class QueueArray<T>
    {
        T[] Data;
        int size = 0;
        int Front;
        int Rear;
        public QueueArray(int size)
        {
            this.size = size;
            Data = new T[size];
            Front = -1;
            Rear = -1;
        }
        public void Queue(T element)
        {
            if (Rear + 1 == size) return;
            Data[++Rear] = element;
            if (Front == -1) Front = 0;
        }
        public T Dequeue()
        {
            if (Front == -1) return default(T);
            T x = Data[Front];
            Data[Front++] = default(T);
            if (Rear<Front) Rear = Front = -1; 
            return x;
        }


        
    }
}
