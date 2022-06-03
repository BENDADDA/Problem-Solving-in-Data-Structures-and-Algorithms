using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class StackLinkList<T>
    {
        
        Node<T> head;
        public int Top = -1;  
        public void Push(T element)
        {
            if (Top == -1) { head = new Node<T>(element, null);}
            else
            {

                Node<T> newnode = new Node<T>(element, head);
                head = newnode;
            }
            Top++;
        }
   
        
        public T Pop()
        {
            if (Top == -1) return default(T);//the stacklinklist is empty   
            object x = head.value;
            head = head.next;
            Top--;
            return (T) x;
        }
       
       
       
    }
}
