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
            if (branch.Branches.Count == 0)
            {
                return 1;
            }

            int maxDepth = 0;
            foreach (var child in branch.Branches)
            {
                int depth = child.CalculateDepth();
                if (depth > maxDepth)
                {
                    maxDepth = depth;
                }
            }

            return maxDepth + 1;
        }
    }
}
