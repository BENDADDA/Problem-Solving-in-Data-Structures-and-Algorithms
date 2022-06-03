using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stack
{
    class NodeDouble<T>
    {
       public T data;
       public  NodeDouble<T> next;
       public NodeDouble<T>pervous;
        public NodeDouble( NodeDouble<T> pervous, T data, NodeDouble<T>next)
        {
            this.data = data;
            this.next = next;
            this.pervous = pervous;
        }

    }
}
