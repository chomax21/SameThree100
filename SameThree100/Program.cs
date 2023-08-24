// See https://aka.ms/new-console-template for more information
TreeNode firstNodeLeft = new(2);
TreeNode firstNodeRigth = new();
TreeNode firstNode = new(val:1, firstNodeLeft, firstNodeRigth);

TreeNode secondNodeLeft = new(0);
TreeNode secondNodeRigth = new(2);
TreeNode secondNode = new(val: 1, secondNodeLeft, secondNodeRigth);

Solution solution = new Solution();
Console.WriteLine($"{firstNode.val} + {firstNode.left.val} + {firstNode.right.val}");
Console.WriteLine(solution.IsSameTree(firstNode,secondNode));

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode lefr = null, TreeNode rigth = null)
    {
        this.val = val;
        this.left = lefr;
        this.right = rigth;
    }
}


public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null) return true;
        if (p != null && q != null && p?.val == q?.val && p.left.val == q.left.val && q.right.val == p.right.val) return true;
        if (p == null || q == null) return false;
        return false;   
    }
}