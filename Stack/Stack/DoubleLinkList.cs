using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class DoubleLinkList<T>
    {
        NodeDouble<T> head;
        NodeDouble<T> last;
        int size=0;
        //Insert node at the start of the linked list  
        public void Add(T element) 
        {
            if (size == 0) { head = new NodeDouble<T>(null, element, null); last = head; }
            else 
            {
                NodeDouble<T> NewNode =new NodeDouble<T>(null,element,null); 
                NewNode.next = head;
                head.pervous = NewNode;
                head = NewNode;
            }
            size++;
        }
        //Insert node at the end of the liked list
        public void Addlast(T element)
        {
            if (size == 0) { head = new NodeDouble<T>(null, element, null); last = head; }
            else
            {
                NodeDouble<T> NewNode = new NodeDouble<T>(null, element, null);
                NewNode.pervous = last;
                last.next= NewNode;
                
            }
            size++;
        }

        public void AddBetween(T element, int index)
        {
            NodeDouble<T> newnode = new NodeDouble<T>(null, element, null);

            if (index == 0) Add(element);
            else
            {
                if (index == size-1) Addlast(element);
                else
                {
                    NodeDouble<T> temp=head;
                    for (int i = 0; i <index-1; i++)
                    {
                        temp = temp.next;
                    }
                    newnode.pervous = temp;
                    newnode.next = temp.next;
                    temp.next.pervous = newnode;
                    temp.next = newnode;

                }
            }
            size++;

        }
        //Print the liked list
        public void Print()
        {
            NodeDouble<T> temp = head;
            while (temp != null)
            {
                Console.Write(" <=> " + temp.data);
                temp = temp.next;
            }
        }
        public void Clear()
        {
            head = null;
            size = 0;
        }
        public bool IsEmpty()
        {
            if (size == 0) return true;
            return false;
        }
        public int GetSize() 
        {
            return size;
        }
        //Delete node whit given index in a liked list
        public void Remove(int index,int x=1)
        {
            if (x*size == 0) return;
            if (index == 0)
            {
                head = head.next;
                head.pervous = null;
                return;
            }
            NodeDouble<T> temp = head;
            for (int i = 0; i < index-1; i++)
            {
                temp = temp.next;
            }
            temp.next = temp.next.next;
            if (temp.next != null) temp.next.pervous = temp;
            size--;
        }
        //Search 
        public bool Search(T Value)
        {
            NodeDouble<T> temp = head;
            while (temp != null)
            {

                if (temp.data.Equals(Value)) return true;
                temp = temp.next;
               
            }
            return false;
        }
        //Reverse the linkedlist
        public void Reverse()
        {
            NodeDouble<T> root=null;
            NodeDouble<T> temp=head;
            while (temp != null)
            {
                NodeDouble<T> newnode = new NodeDouble<T>(null, temp.data,root);
                if (root!= null) root.pervous = newnode;
                root = newnode;
                temp = temp.next;
            }
            head = root;
        }
       
    }
}
