using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.Tree
{
    internal class SymetricTreeAlgorithm
    {
        public bool IsSymmetric(TreeNode root)
        {
            return IsSymetricTree(root.left, root.right);
        }

        public bool IsSymetricTree(TreeNode n1, TreeNode n2)
        {
            if (n1 == null && n2 == null)
                return true;

            if (n1 == null || n2 == null)
                return false;

            if(n1.val != n2.val)
                return false;


            return IsSymetricTree(n1.left, n2.right) && IsSymetricTree(n1.right, n2.left);

        }
    }
}
