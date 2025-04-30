namespace ItsLeet.Tree;

public class InvertBinaryTree
{
    public TreeNode? InvertTree(TreeNode? root) {
        if (root == null)
        {
            return root;
        }

        (root.right, root.left) = (root.left, root.right);
        InvertTree(root.left);
        InvertTree(root.right);
        return root;
    }
}