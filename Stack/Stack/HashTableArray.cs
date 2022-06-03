using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class HashTableArray<T>
    {
        Entry<T>[]Data;
        int key;
        int Size;
        public HashTableArray(int Size)
        {
            Data = new Entry<T>[Size];
            this.Size = Size;
            for (int i = 0; i < Size; i++)
                Data[i] = new Entry<T>();
            
        }
        int GetHash(int Key)
        {
            return Key%Size;
        }
        public void Put(int Key, T Value)
        {   
            int index=GetHash(Key);
            Entry<T> NewItem = new Entry<T>(Key, Value);
            Entry<T> FirstEntry = Data[index];
            NewItem.next = FirstEntry.next;
            FirstEntry.next = NewItem;
            FirstEntry = null;
        }
        public T Out(int Key)
        {
           
            int index = GetHash(Key);
            Entry<T> FirstEntry = Data[index];
            while (FirstEntry.next != null)
            {
                if (FirstEntry.next.Key ==Key) return  FirstEntry.next.Value;
                
                FirstEntry = FirstEntry.next;
            }
            FirstEntry = null;
            return default(T);
        }

   
    }
}
