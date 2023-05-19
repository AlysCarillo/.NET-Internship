using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TreeDepthCalculator.Models;

namespace TreeDepthCalculator
{
    public static class TreeStructure
    {
        public static int CalculateDepth(this Branch branch)
        {
            return CalculateDepthRecursive(branch);
        }

        private static int CalculateDepthRecursive(Branch branch)
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

        public static void DisplayTree(this Branch branch)
        {
            DisplayTreeRecursive(branch, "", true);
        }

        private static void DisplayTreeRecursive(Branch branch, string indent, bool isLast)
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

            Console.WriteLine(branch.Name);

            int childCount = branch.Branches.Count;
            for (int i = 0; i < childCount; i++)
            {
                bool lastChild = (i == childCount - 1);
                DisplayTreeRecursive(branch.Branches[i], indent, lastChild);
            }
        }
    }
}
