using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.Tree
{
    //    2
    // 1    3
    //
    //   2
    // 1
    //
    //      3
    //   2     4
    // 0   1

    public class BinaryTreeInorderTraversal
    {
        private IList<int> result = new List<int>();
        public IList<int> InorderTraversal(TreeNode? root)
        {
            if (root == null) return result;

            InorderTraversal(root.left);

            result.Add(root.val);

            InorderTraversal(root.right);

            return result;
        }


    }
}
