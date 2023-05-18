using TreeDepthCalculator.Models;

namespace TreeDepthCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Create the tree structure
            Branch root = new Branch("50");

            Branch d1child1 = new Branch("25");
            Branch d1child2 = new Branch("65");
            Branch d2child3 = new Branch("15");
            Branch d2child4 = new Branch("66");
            Branch d2child5 = new Branch("70");
            Branch d2child6 = new Branch("75");
            Branch d3child7 = new Branch("67");
            Branch d3child8 = new Branch("71");
            Branch d3child9 = new Branch("73");
            Branch d4child10 = new Branch("72");

            root.Branches.Add(d1child1);
            root.Branches.Add(d1child2);

            d1child1.Branches.Add(d2child3);

            d1child2.Branches.Add(d2child4);
            d1child2.Branches.Add(d2child5);
            d1child2.Branches.Add(d2child6);

            d2child4.Branches.Add(d3child7);

            d2child5.Branches.Add(d3child8);
            d2child5.Branches.Add(d3child9);

            d3child8.Branches.Add(d4child10);

            // Calculate the depth of the tree using recursion
            int depth = root.CalculateDepth();

            // Display the depth of the tree
            Console.WriteLine($"Depth of the tree: {depth}");

            Console.WriteLine(root);
        }
    }
}