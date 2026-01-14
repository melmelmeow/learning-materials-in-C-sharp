using System;

public class TreeNode
{
    public int Value;
    public TreeNode Left;
    public TreeNode Right;
    public TreeNode(int value) { Value = value; }
}

class Program
{
    static void Main()
    {
        // Build the small binary tree from the example
        TreeNode root = new TreeNode(10);
        root.Left = new TreeNode(5);
        root.Right = new TreeNode(15);
        
        Console.WriteLine("Tree Structure:");
        Console.WriteLine("    10");
        Console.WriteLine("   /  \\");
        Console.WriteLine("  5    15");
        Console.WriteLine();
        
        Console.WriteLine("InOrder Traversal:");
        InOrder(root);
        Console.WriteLine();
        
        Console.WriteLine("PreOrder Traversal:");
        PreOrder(root);
        Console.WriteLine();
        
        Console.WriteLine("PostOrder Traversal:");
        PostOrder(root);
        Console.WriteLine();
    }
    
    static void InOrder(TreeNode node)
    {
        if (node == null) return;
        InOrder(node.Left);
        Console.Write(node.Value + " ");
        InOrder(node.Right);
    }
    
    static void PreOrder(TreeNode node)
    {
        if (node == null) return;
        Console.Write(node.Value + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }
    
    static void PostOrder(TreeNode node)
    {
        if (node == null) return;
        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Value + " ");
    }
}
