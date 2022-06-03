using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class LinkList<T>
    {

        Node<T> head;
        int Size = 0;
        Node<T> Last;
        public void Add(T element)
        {
            Node<T> newnode = new Node<T>(element, head);
            head = newnode;
            if (Size == 0) Last = head;
            Size++;
                          
        }


        public void AddEnd(T element)
        {
            Node<T> newnode = new Node<T>(element, null);
            if (Size == 0) Last = head = newnode;
            else { Last.next = newnode; Last = Last.next; }       
            Size++;

        }
        public void AddBetween(T element,int index)
        {
            Node<T> nv = new Node<T>(element, null);

            int i = 0;
            if (index == 0)
            {
                nv.next = head;
                head = nv;
            }
            else
            {
                Node<T> temp = head;
                while (i < index - 1)
                {
                    temp = temp.next;
                    i++;
                }
                nv.next = temp.next;
                temp.next = nv;
                if (Size == index) Last = nv;
                temp = null;
            }

            Size++;
            nv = null;

        }
        public void Display()
        {
            Node<T> temp = head;
            while (temp != null)
            {
                Console.Write("->" + temp.value);
                temp = temp.next;
            }
            temp = null;
        }
        public int GetSize()
        {
            return Size;
        }
        public bool Contains(T element)
        {
            Node<T> temp = head; bool v = false;
            while (temp != null)
            {
                if (temp.value.Equals(element)) { v = true; break; }
                temp = temp.next;
            }
            return v;
            temp = null;
        }

        public void Remove(int index, int cmd = 1)
        {
            if (cmd == 1)
            {
                if (index == 0)
                {
                    head = head.next;
                }
                else
                {
                    int i = 0;
                    Node<T> temp = head;
                    while (i < index - 1)
                    {
                        temp = temp.next;
                        i++;
                    }
                    temp.next = temp.next.next;
                    temp = null;
                }
                Size--;
            }
        }
        public void Clear()
        {
            head = null;
            Size = 0;
        }
        public LinkList<T> CopyTo(LinkList<T> lkl)
        {
            LinkList<T> opj = new LinkList<T>();
            Node<T> temp = lkl.head;
            while (temp != null)
            {

                opj.AddEnd(temp.value);
                temp = temp.next;
            }
            return opj;
        }
        public LinkList<T> Mirror(LinkList<T> lkl)
        {
            LinkList<T> opj = new LinkList<T>();
            Node<T> temp = lkl.head;
            while (temp != null)
            {

                opj.Add(temp.value);
                temp = temp.next;
            }
            return opj;
        }

        public void Reverse()
        {
            Node<T> root=null;
            Node<T> temp=head;
            while (temp != null)
            {
                Node<T> newnode = new Node<T>(temp.value,root);
                root = newnode;
            }
            head = root;
        }
        //Insert an element in sorted order in linked list given head pointer
        public void AddSort(T element)
        {
            Node<T> newnode=new Node<T>(element,null);
           

        }

    }
}
