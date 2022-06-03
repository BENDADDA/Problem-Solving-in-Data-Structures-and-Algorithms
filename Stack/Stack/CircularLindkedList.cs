using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class CircularLindkedList<T>
    {
        Node<T> head;
        Node<T> last;
        int size = 0;
        
        // adding an element at the beginning of a circular linked list
        // the complexty time is O(1).
        public void Add(T element)
        {
            Node<T> newnode = new Node<T>(element, head);
            head = newnode;
            if (size == 0) last = head;
            last.next = head;
            size++;
        }

        // added element at the end of a circular linked list
        // the complexty time is O(1).
        public void AddEnd(T element)
        {
            Node<T> newnode = new Node<T>(element, head);
            if (size == 0) head = last=newnode;
            last.next = newnode;
            last = last.next;
            size++;
        }

        // print the elements of the List.
        // the complexty time is O(n).
        public void Print()
        {
            Node<T> temp = head;
            for (int i = 0; i < size; i++)
            {
                Console.Write("->" + temp.value);
                temp = temp.next;
            }
        }
        public void Explorer()
        {
            int i = 0;
            Node<T> temp = head;
            while (temp.next!=null)
            {         
                Console.Write("->" + temp.value);
                temp = temp.next; 
            }

        }
        public bool IsEmpty()
        {
            if (size == 0) return false;
            return true;
        }
        public void Clear()
        {
            head = last = null;
        }
        // Search particular value in a circular linked list.
        // complexty time is O(n).
        public bool Search(T value)
        {
            Node<T>temp=head;
            for(int i=0;i<size;i++)
            {
                if (temp.value.Equals(value)) return true;
                temp = temp.next;
            }
            return true;
        }
        // remove first element of the linked list
        // order,insert sorter order.
        public void Remove(int index)
        { 
           
        }
    }
}
