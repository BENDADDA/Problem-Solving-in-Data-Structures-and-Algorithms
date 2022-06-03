using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{

    class PriorityQueue<T> where T : IComparable<T>
    {
        private const int CAPACITY = 16;
        private int size;
        private T[] array;
        private bool IsMinHeap;

        public PriorityQueue(bool IsMinHeap = true)
        {
            this.IsMinHeap = IsMinHeap;
            this.size = 0;
            this.array = new T[CAPACITY];

        }

        public PriorityQueue(T[] arr, bool IsMinHeap = true)
        {
            this.IsMinHeap = IsMinHeap;
            this.size = arr.Length;
            array = new T[size];
            Array.Copy(arr, array, size);
            for (int i = size / 2; i >= 0; i--)
                Heapify(i);

        }
        // heapfiy,O(logn);
        private void Heapify(int px)
        {
            int lx = 2 * px + 1;
            int rx = 2 * px + 2;
            int nx = -1;
            if (lx < size)
            {
                nx = lx;
            }
            if (rx < size)
            {
                if (comp(rx, lx) < 0) nx = rx;
            }
            if (nx != -1)
            {
                if (comp(nx, px) < 0)
                {
                    Swap(nx, px);
                    Heapify(nx);
                }
            }
            else return;

        }
        // Swap
        private void Swap(int a, int b)
        {
            T temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
        //
        private int comp(int first, int second)
        {
            if (IsMinHeap) return array[first].CompareTo(array[second]);
            else return array[second].CompareTo(array[first]);
        }
        // Dynamic Size
        private void DynamicSize()
        {
            if (size == array.Length)
            {
                T[] table = new T[size * 2];
                Array.Copy(array, table, size);
                array = table;
            }
        }
        // Add an elemet in the queue,the complexty time is O(logn).
        public void Enqueue(T element)
        {
            DynamicSize();
            array[size] = element;
            Add(size);
            size++;
        }
        private void Add(int ci)
        {
            if (ci == 0) return;
            int pi = ci / 2;
            if (comp(ci, pi) < 0)
            {
                Swap(ci, pi);
                Add(pi);
            }
        }
        //--------------------------
        public T Dequeue()
        {
            
            T value = array[0];
            Swap(0, --size);
            array[size] = default(T);
            Heapify(0);

            return value;

        }
        public bool IsEmpty()
        {
            if (size == 0) return true;
            else return false;
        }

        public int Count
        {
            get
            {
                return size;
            }
        }
        public void Print()
        {
            for (int i = 0; i < size; i++)
                Console.Write(array[i] + " ");
        }
        // heapsort ,O(nlogn)
        public void Sort(T[] array, bool IsMinHeap = true)
        {
            PriorityQueue<T> NewHeap = new PriorityQueue<T>(array, IsMinHeap);
            for (int i = 0; i < array.Length; i++)
                array[i] = NewHeap.Dequeue();
        }
        //Remonve an item with givening an index
        public void Remove(int Index)
        {
            Swap(Index, --size);
            array[size] = default(T);
            Heapify(Index);
        }

        //Clear
        public void Clear()
        {
            array = new T[CAPACITY];
            size = 0;
        }

    }
}
