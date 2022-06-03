using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    class Vertice:IComparable<Vertice>
    {
        internal int source;
        internal int destination;
        internal int cost;
        internal Vertice next;
        public Vertice(int source, int destination, int cost)
        {
            this.source = source;
            this.destination = destination;
            this.cost = cost;
            this.next = null;
        }
        
        public Vertice(int source,int destination):this(source,destination,1)
        {}

        int IComparable<Vertice>.CompareTo(Vertice other)
        {
            return Math.Sign(cost - other.cost);
        }

       
        


    }
}
