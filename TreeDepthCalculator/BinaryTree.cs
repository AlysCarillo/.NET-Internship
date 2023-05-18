using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDepthCalculator.Models;

namespace TreeDepthCalculator
{
    public class BinaryTree
    {
        private Node root;

        public BinaryTree()
        {
            root = null;
        }

        public void AddNode(int value)
        {
            root = RecursiveAddNode(root, value);
        }

        private Node RecursiveAddNode(Node current, int value)
        {
            if (current == null)
            {
                Node newNode = new Node();
                newNode.Value = value;
                return newNode;
            }

            if (value < current.Value)
            {
                current.Left = RecursiveAddNode(current.Left, value);
            }
            else if (value > current.Value)
            {
                current.Right = RecursiveAddNode(current.Right, value);
            }

            return current;
        }

        
    }
}
