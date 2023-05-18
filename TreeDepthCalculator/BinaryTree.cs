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

        public void DisplayTree()
        {
            DisplayTree(root, 0);
        }

        private void DisplayTree(Node node, int level)
        {
            if (node == null)
            {
                return;
            }

            DisplayTree(node.Right, level + 1);

            Console.WriteLine();
            if (node == root)
            {
                Console.Write("Root: ");
            }
            else
            {
                Console.Write("|");
                for (int i = 0; i < level; i++)
                {
                    Console.Write("    ");
                }
                Console.Write("|---");
            }
            Console.Write(node.Value);

            DisplayTree(node.Left, level + 1);
        }
    }
}
