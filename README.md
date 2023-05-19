# Tree Depth Calculator
The Tree Depth Calculator is a simple program that calculates the depth of a tree structure using a recursive approach. It also provides a method to display the tree structure in a hierarchical manner.

# Installation
To use the Tree Depth Calculator, follow these steps:

1. `Clone` the repository or download the source code.
2. Open the project in your preferred development environment (e.g., Visual Studio).
3. Build the project to ensure all dependencies are resolved.

# Usage
The Tree Depth Calculator provides a Branch class that represents a branch in a tree structure. Each branch can have multiple child branches, forming a hierarchical tree.

To calculate the depth of a tree structure:

1. Create a Branch object representing the root of the tree.
2. Add child branches to the root branch by creating new Branch objects and adding them to the Branches collection of the parent branch by using `branchName.Branches.Add(new Branch(string value))`.
3. Use the CalculateDepth() method of the Branch class to calculate the depth of the tree structure.

Sample output:

![image](https://github.com/AlysCarillo/TreeDepthCalculator/assets/111732588/a03441ec-9292-410f-8c6e-d843a5904103)

