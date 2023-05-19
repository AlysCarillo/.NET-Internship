using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeDepthCalculator.Models;

namespace TreeDepthCalculator.TreeStructures
{
    public interface ITreeStructure
    {
        int CalculateDepth(Branch branch);

        void DisplayTree(Branch branch);
    }
}
