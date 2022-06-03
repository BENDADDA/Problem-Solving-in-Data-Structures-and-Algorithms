using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
 public class BinaryTree
    {
        Node root;
        Node rootExplore;

        public BinaryTree()
    {
        root = rootExplore = null;
    }
        public void Add(int elment) //The complexty time it is n.
        {
            if (root == null)// node is null
            {
                root = new Node(null, elment, null);
                rootExplore = root;
             
                return;
            }
            
            // node is not null
                if (rootExplore.value < elment)
                {
                    if (rootExplore.right == null)
                    {
                        rootExplore.right = new Node(null, elment, null);
                        rootExplore = root;

                    }

                    else
                    {
                        rootExplore = rootExplore.right;
                        Add(elment);
                    }
                }
                else
                {
                    if (rootExplore.left == null)
                    {
                        rootExplore.left = new Node(null, elment, null);
                        rootExplore = root;
                    }

                    else
                    {
                        rootExplore = rootExplore.left;
                        Add(elment);
                    }
                }


             
        }

         void Add1(int elment ,Node node) //The complexty time it is n.
        {
            if (node == null)// node is null
            {
                nd = new Node(null, elment, null);
                node = nd;
                return;
            }

            // node is not null
            if (node.value < elment)
            {
                if (node.right == null)
                {
                   node.right = new Node(null, elment, null);
                  

                }

                else
                {

                    Add1(elment, node.right);
                }
            }
            else
            {
                if (node.left == null)
                {
                   node.left = new Node(null, elment, null);
                   
                }

                else
                {

                    Add1(elment, node.left);
                }
            }



        }
        
        public void Search(int elment)// The complexty time it is n.
        {
          
            if (rootExplore.value == elment)
            {
                Console.Write("{0} is  found",elment);
                rootExplore = root;
                return;
            }
            if (rootExplore.value < elment)
            {
                if (rootExplore.right == null)
                {

                    Console.Write("{0} is not found",elment);
                    rootExplore = root;
                }

                else
                {
                    rootExplore = rootExplore.right;
                    Search(elment);
                }
            }
            else
            {
                if (rootExplore.left == null)
                {

                    Console.Write("{0} is not found",elment);
                    rootExplore = root;

                } 

                else
                {
                    rootExplore = rootExplore.left;
                    Search(elment);
                }
            }

        }

       
        void Display(Node node)
        {
            if (node== null)
            {
                return;
            }

            Console.Write(node.value + " ");
            Display(node.left);
            Display(node.right);
        }
        public void Display()
        {
            Display(root);
        }

        Node nd = null;
        void remove(Node node, int value)// -The complexty time it is n².
        {
            if (node == null)
            {
                return;
            }
            //-------------
            if (node.value != value)
            {
                Add1(node.value, nd); 
            }
           //-------------------------------
            remove(node.left, value);
            remove(node.right, value);
        }
         void Remove1(int value)
        {

            remove(root, value);
            root=nd;
        }
        // stting of the Remove function ,the complexty is O(n). 
         Node removeh(Node node)// for remove header node of the binary tee,the complexty is O(n).
        {
            if (node.left == null && node.right == null)
            {
                node = null;
            }
            else if (node.left != null)
            {
                Node noder = node.right;
                node.right = null;
                node = node.left;
                Node nodetemp = node;

                while (nodetemp.right != null)
                {
                    nodetemp = nodetemp.right;
                }
                nodetemp.right = noder;

            }
            else node = node.right;

            return node;
        }
         void removes(int value)
         {
             if (rootExplore == null) return;
             if (rootExplore.value < value)
             {
                 if (rootExplore.right == null) return;
                 else if (rootExplore.right.value == value)
                 {
                     rootExplore.right = removeh(rootExplore.right);
                     rootExplore = root;
                 }
                 else
                 {
                     rootExplore = rootExplore.right;
                     removes(value);
                 }



             }
             else
             {
                 if (rootExplore.left == null) return;
                 else if (rootExplore.left.value == value)
                 {
                     rootExplore.left = removeh(rootExplore.left);
                     rootExplore = root;
                 }
                 else
                 {
                     rootExplore = rootExplore.left;
                     removes(value);
                 }

                
             }

             
         }
        public void Remove(int value)// Function Remove ,The Complexty Time is n.
        {
            if (root.value == value) root = removeh(root);
            else removes(value);
                
        }


        //Graph(Binary Tree)  Representation whith matrix and  Adjacency List
     // first whit matrix.

    }
    
}
