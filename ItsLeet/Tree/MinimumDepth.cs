namespace ItsLeet.Tree;

public class MinimumDepth
{
    public int MinDepth(TreeNode? root)
    {
        if (root == null) {
            return 0;
        } else if (root.left == null && root.right == null) {
            return 1;
        } else {
            int min = 1000000;
            if (root.left != null) {
                min = Math.Min(min, MinDepth(root.left));
            }
            if (root.right != null) {
                min = Math.Min(min, MinDepth(root.right));
            }
            return min + 1;
        }
    }
}