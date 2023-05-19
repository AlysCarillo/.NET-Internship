using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDepthCalculator.Models
{
    public class Branch
    {
        public string Name { get; set; }
        public List<Branch> Branches { get; set; }

        public Branch(string name)
        {
            Name = name;
            Branches = new List<Branch>();
        }
    }
}
