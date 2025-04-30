namespace ItsLeet.Tree;

public class ConstructBinaryTreeFromPreOrderandInOrder
{
    public TreeNode? BuildTree(int[] preorder, int[] inorder)
    {
        var treeNode = new TreeNode(preorder[0]);
        for (var i = 1; i < preorder.Length; i++)
        {
            treeNode = PreOrderTreeBuilder(preorder, treeNode.left);
            treeNode = PreOrderTreeBuilder(preorder, treeNode.right);
        }

        return treeNode;
    }
    
    

    private TreeNode? PreOrderTreeBuilder(int[] preOrder, TreeNode? treeNode)
    {
        for (int i = 0; i < preOrder.Length; i++)
        {
            treeNode = new TreeNode(preOrder[i]);
        }

        /// to be completed
        return treeNode;
    }
}