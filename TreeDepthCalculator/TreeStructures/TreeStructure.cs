using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TreeDepthCalculator.Models;

namespace TreeDepthCalculator.TreeStructures
{
    public class TreeStructure : ITreeStructure
    {
        public int CalculateDepth(Branch branch)
        {
            return CalculateDepthRecursive(branch);
        }

        private int CalculateDepthRecursive(Branch branch)
        {
            if (branch.Branches.Count == 0)
            {
                return 1;
            }

            int maxDepth = 0;
            foreach (var child in branch.Branches)
            {
                int depth = CalculateDepthRecursive(child);
                if (depth > maxDepth)
                {
                    maxDepth = depth;
                }
            }

            return maxDepth + 1;
        }

        public void DisplayTree(Branch branch)
        {
            DisplayTreeRecursive(branch, "", true);
        }

        private void DisplayTreeRecursive(Branch branch, string indent, bool isLast)
        {
            Console.Write(indent);

            if (isLast)
            {
                Console.Write("└─ ");
                indent += "   ";
            }
            else
            {
                Console.Write("├─ ");
                indent += "│  ";
            }

            Console.WriteLine(branch.Value);

            int childCount = branch.Branches.Count;
            for (int i = 0; i < childCount; i++)
            {
                bool lastChild = i == childCount - 1;
                DisplayTreeRecursive(branch.Branches[i], indent, lastChild);
            }
        }
    }
}
