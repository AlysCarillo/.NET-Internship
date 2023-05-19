using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeDepthCalculator.Models
{
    public class Branch
    {
        public string Value { get; set; }
        public List<Branch> Branches { get; set; }

        public Branch(string value)
        {
            Value = value;
            Branches = new List<Branch>();
        }
    }
}
