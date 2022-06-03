using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    public class LinkedListQueue<T>
    {
        NodeDouble<T> Front;
        NodeDouble<T> Rear;
      
        int size;
        public LinkedListQueue()
        {
            size = 0;
        }
        public void Queue(T element)
        {
            if (Rear == null)
            {
               Rear = new NodeDouble<T>(null, element, null);
                Front=Rear; 
            }
            else
            {
                NodeDouble<T> temp = new NodeDouble<T>(Rear,element,null);
                Rear.next = temp;
                Rear = temp;
                temp = null;
            }
            size++;
        }

        public T DeQueue()
        {
            if (Front == null) return default(T);
            T x = Front.data;
            Front = Front.next;
            if(Front!=null)Front.pervous = null;
            size--;
            return x;
        }
        public void  Clear()
        {
            Front=Rear=null;
            size=0;
        }
        public int GetSize()
        {
            return size;
        }
        // solve problem with empty queue after adde
    }
}
