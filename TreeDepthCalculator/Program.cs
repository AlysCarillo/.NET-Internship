using TreeDepthCalculator.Models;
using TreeDepthCalculator.TreeStructures;

namespace TreeDepthCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create the tree structure
            Branch root = new Branch("50");

            Branch child25 = new Branch("25");
            child25.Branches.Add(new Branch("15"));

            Branch child65 = new Branch("65");
            child65.Branches.Add(new Branch("66")
            {
                Branches = { new Branch("67") }
            });
            child65.Branches.Add(new Branch("70")
            {
                Branches =
                {
                    new Branch("71")
                    {
                        Branches = { new Branch("72") }
                    },
                    new Branch("73")
                }
            });
            child65.Branches.Add(new Branch("75"));

            root.Branches.Add(child25);
            root.Branches.Add(child65);

            // Display the tree
            ITreeStructure treeStructure = new TreeStructure();
            treeStructure.DisplayTree(root);

            Console.WriteLine($"\nDepth of the tree: {treeStructure.CalculateDepth(root)}");
        }
    }
}