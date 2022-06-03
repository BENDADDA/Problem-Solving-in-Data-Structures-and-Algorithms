using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class Entry<T>
    {
       public T Value;
       public int Key;
       public Entry<T> next;
        public Entry( int Key,T Value)
        {
            this.Value = Value;
            this.Key = Key;
            next = null;
        }
        public Entry()
        {
          
            next = null;
        }
        
        
       
    }
}
