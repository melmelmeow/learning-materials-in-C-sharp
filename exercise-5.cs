public class TreeNode
{
    public int Value;
    public TreeNode Left;
    public TreeNode Right;
    public TreeNode(int value) { Value = value; }
}

void InOrder(TreeNode node)
{
    if (node == null) return;
    InOrder(node.Left);
    Console.WriteLine(node.Value);
    InOrder(node.Right);
}

// Example tree
TreeNode root = new TreeNode(10);
root.Left = new TreeNode(5);
root.Right = new TreeNode(15);

InOrder(root); // Output: 5, 10, 15
