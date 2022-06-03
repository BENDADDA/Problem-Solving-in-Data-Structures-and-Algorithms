using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    class Node
    {
        public int value;
        public Node left;
        public Node right;
        public Node(Node left,int value,Node right)
        {
            this.left = left;
            this.value = value;
            this.right = right;
        }
      
    }
}
