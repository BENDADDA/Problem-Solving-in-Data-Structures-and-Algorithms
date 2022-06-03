using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class CircleData<T>
    {
        Object[] Data;
        int size ;
        int Front;
        int Rear;

        public CircleData(int size)
        {
            this.size = size;
            Data = new Object[size];
            Front = 0;
            Rear = -1;
        }

        int i;
        public void Queue(T element)
        {
           i = (Rear + 1) % size;
           if(Data[i]!=null) return;
           Rear++;
           Data[i] = element;
        }
        public T Dequeue()
        {
            i = Front % size;
            if(Data[i]==null) return default(T);
            Object x = Data[i];
            Data[i] = null;
            Front++;
            return (T)x;
        }

       
    }
}

