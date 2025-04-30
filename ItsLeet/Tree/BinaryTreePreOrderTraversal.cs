namespace ItsLeet.Tree;

public class BinaryTreePreOrderTraversal
{
    private IList<int> _result = new List<int>();
    public IList<int> PreorderTraversal(TreeNode? root)
    {
        if (root == null)
        {
            return _result;
        }
        
        _result.Add(root.val);
        _result = PreorderTraversal(root.left);
        _result = PreorderTraversal(root.right);

        return _result;
    }
}