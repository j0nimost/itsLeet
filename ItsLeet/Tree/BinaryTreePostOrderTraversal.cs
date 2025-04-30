namespace ItsLeet.Tree;

public class BinaryTreePostOrderTraversal
{
    private IList<int> _result = new List<int>();
    public IList<int> PostorderTraversal(TreeNode? root) 
    {
        if (root == null)
        {
            return _result;
        }

        _result = PostorderTraversal(root.left);
        _result = PostorderTraversal(root.right);
        _result.Add(root.val);

        return _result;
    }
}