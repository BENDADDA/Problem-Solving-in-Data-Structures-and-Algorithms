using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Graph
{
    class Graph
    {
     
        private AdjacencyList[]array;
        private int count;
        
        public Graph(int count)
        {
            this.count = count;
            array = new AdjacencyList[this.count];
            for (int i = 0; i < count; i++)
            {
                array[i] = new AdjacencyList();
                array[i].head = null;

            }

        }
        
        // Add vertic,O(1)
        public void AddVertic(int source, int destination, int cost)
        {
            Vertice NewVertice=new Vertice(source,destination,cost);
            NewVertice.next = array[source].head;
            array[source].head = NewVertice;
            
        }

        public void AddVertic(int source, int destination)
        {
            AddVertic(source, destination, 1);
        }

        public void AddBiEdge(int source, int destination, int cost)
        {
            AddVertic(source, destination, cost);
            AddVertic(destination, source, cost);

        }
        public void AddBiEdge(int source, int destination)
        {
            AddVertic(source, destination, 1);
            AddVertic(destination, source, 1);

        }
        // Add Vertices and edges by Matrix,the complexty time is O(n^2).
        public void Matrix(int[,] Matrix)
        {
            for (int i = 0; i < count; i++)
                for (int j = count - 1; j >= 0; j--)
                    if (Matrix[i, j] != 0) AddVertic(i, j, Matrix[i, j]);
        }
        //-----------------------------------------
        //Graph Traversal
        //DEPTH FIRST SEARSH
        //explore the graph by DFS,the complexe time is O(n)
        public void DFSExplore(int StartVertix)
        {
            
            bool[] visited = new bool[count];
            for (int i = 0; i < count; i++)
                visited[i] = false;
            Stack<int> stack = new Stack<int>();
            stack.Push(StartVertix);
            while (stack.Count != 0)
            {
                int n = stack.Peek();
                visited[n] = true;
                bool isdone = true;
                Vertice head = array[n].head;
                while (head != null)
                {
                    if (!visited[head.destination])
                    {
                        stack.Push(head.destination);
                        isdone = false;
                        break;
                    }
                    else head = head.next;
                }

                if (isdone)
                {
                    int Nout = stack.Pop();
                    Console.WriteLine("visit Vertic:" + Nout);
                }

            }
           


        }
        //Search the graph by DFS for Vertix,the complexe time is O(n)
        //DFS
        public bool DFS(int StartVertix, int element)
        {

            bool[] visited = new bool[count];
            for (int i = 0; i < count; i++)
                visited[i] = false;
            Stack<int> stack = new Stack<int>();
            stack.Push(StartVertix);
            
            while (stack.Count != 0)
            {
                int n = stack.Peek();
                if (n == element) return true;
                visited[n] = true;
                bool isdone = true;
                Vertice head = array[n].head;
                while (head != null)
                {
                    if (!visited[head.destination])
                    {
                        stack.Push(head.destination);
                        isdone = false;
                        break;
                    }
                    else head = head.next;
                }
                if (isdone) stack.Pop();
            }
         
            return false;
        }
        //BEARDTH FIRST SEARSH
        //explore the graph by BFS,the complexe time is O(n)
        public void BFSExplore(int StartVertix)
        {

            bool[] visited = new bool[count];
            for (int i = 0; i < count; i++)
                visited[i] = false;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(StartVertix);
          
            while (queue.Count != 0)
            {
                int n = queue.Peek();
                visited[n] = true;
                Vertice head = array[n].head;
                while (head != null)
                {
                    if (!visited[head.destination])
                    {
                        queue.Enqueue(head.destination);
                        visited[head.destination] = true;
                       
                    }
                    head = head.next;
                }


                int Nout = queue.Dequeue();
                    Console.WriteLine("visit Vertic:" + Nout);
               

            }



        }
        //Search the graph for Vertic by BFS,the complexty time is O(n).
        //BFS
        public bool BFS(int StartVertix,int element)
        {

            bool[] visited = new bool[count];
            for (int i = 0; i < count; i++)
                visited[i] = false;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(StartVertix);

            while (queue.Count != 0)
            {
                int n = queue.Peek();
                visited[n] = true;
                if (n == element) return true;
                Vertice head = array[n].head;
                while (head != null)
                {
                    if (!visited[head.destination])
                    {
                        if (n == head.destination) return true;
                        queue.Enqueue(head.destination);
                        visited[head.destination] = true;

                    }
                    head = head.next;
                }


               queue.Dequeue();
               

            }


            return false;
        }
        //--------------------------------------------------------.

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Vertice head = array[i].head;
                Console.Write("|{0}|",i);
                while(head!=null)
                {
                    Console.Write("-{0}->[{1}]",head.cost,head.destination);
                    head = head.next;
                }
                
                Console.WriteLine("\n");
            }
        }
        // Minimum spanning tree (MST)
        //- Prim's Algorithm,the complexty time is O(m.logn) where m numeber of edges
        // worst cinaryou O(n^2*logn).
        public void Prim(int StartVartix)
        {
            int n = StartVartix;
            int[] source = new int[count - 1];
            int[] cost = new int[count - 1];
            int[] destination = new int[count - 1];
            bool[] visited = new bool[count];
            for (int i = 0; i < count; i++) visited[i] = false;
            PriorityQueue<Vertice> queue = new PriorityQueue<Vertice>();
            visited[n] = true;
            for (int i = 0; i < count - 1; i++)
            {
                
                Vertice head = array[n].head;
                while (head != null)
                {
                    if (!visited[head.destination])
                    {
                        Vertice v = new Vertice(head.source, head.destination, head.cost);
                        queue.Enqueue(v);
                    }
                    head = head.next;
                }       
                Vertice vertice = queue.Dequeue();
                while (visited[vertice.destination])
                {
                     vertice = queue.Dequeue();
                }
                source[i] = vertice.source;
                cost[i] = vertice.cost;
                destination[i] = vertice.destination;
                n = vertice.destination;
                visited[n] = true;
                
            }
            
            // print edges
            for (int i = 0; i < count-1; i++)
            {
                Console.WriteLine(source[i] + " -" + cost[i] + "->" + destination[i]);
            }


        }

        //Kruskal's Algorithm
        //
        public void Kruskal()
        {
            int[] source = new int[count - 1];
            int[] cost = new int[count - 1];
            int[] destination = new int[count - 1];
            bool[] visited = new bool[count];  
            for (int i = 0; i < count; i++) 
                 visited[i] = false;
            PriorityQueue<Vertice> queue = new PriorityQueue<Vertice>();
            for (int i = 0; i < count; i++) // For select all edges of  the graph
            {
                
                Vertice head = array[i].head;
                while (head != null)
                {
                    if (!(visited[head.destination]))
                    {
                        Vertice v = new Vertice(head.source, head.destination, head.cost);
                        queue.Enqueue(head);
                    }
                    head = head.next;
                }
                visited[i] = true;
            }
            int L = queue.Count; int j = 0;// For sort edges
            Vertice[] V = new Vertice[L];
            for (int i = 0; i <L; i++) V[i] = queue.Dequeue();
            Graph g = new Graph(count);
            for (int i = 0; i <L; i++)  //For choosing edges 
            {
                int s = V[i].source;
                int c = V[i].cost;
                int d = V[i].destination;
                if (!(g.BFS(d,s))) 
                {
                    source[j] = V[i].source;
                    cost[j]= V[i].cost;
                    destination[j] = V[i].destination;
                    g.AddBiEdge(s, d);
                    j++;
                    if (j == count - 1) break;
                }

            }


            // print edges
            for (int i = 0; i < count - 1; i++)
            {
                Console.WriteLine(source[i] + "-" + cost[i] + "->" + destination[i]);
            }


        }
        
        //----------------------------------------------------------------------------------
        //Shorth Path Algorithms
        //- Dijkstar's Algorithm
        public void Dijkstar(int StartVartix)
        {
            int n = StartVartix;
            int[] source = new int[count - 1];
            int[] cost = new int[count - 1];
            int[] destination = new int[count - 1];
            bool[] visited = new bool[count];
            for (int i = 0; i < count; i++) visited[i] = false;
            PriorityQueue<Vertice> queue = new PriorityQueue<Vertice>();
            visited[n] = true; int D = 0;
            for (int i = 0; i < count - 1; i++)
            {

                Vertice head = array[n].head;
                while (head != null)
                {
                    if (!visited[head.destination])
                    {
                        Vertice v = new Vertice(head.source, head.destination, head.cost+D);
                        queue.Enqueue(v);
                    }
                    head = head.next;
                }
                Vertice vertice = queue.Dequeue();
                while (visited[vertice.destination])
                {
                    vertice = queue.Dequeue();
                }
                source[i] = vertice.source;
                cost[i] = vertice.cost;
                destination[i] = vertice.destination;
                D = vertice.cost;
                n = vertice.destination;    
                visited[n] = true;

            }

            //Print edges
            for (int i = 0; i < count - 1; i++)
            {
                Console.WriteLine(source[i] + " -"+cost[i]+"->" + destination[i]);
            }


        }









    }
}
