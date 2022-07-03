using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.Tree
{
    internal class BalancedBinaryTree
    {
        private int MaxDepth(TreeNode root)
        {

            if (root == null)
                return 0;

            return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
        }

        public bool IsBalanced(TreeNode root)
        {
            if(root == null)
                return true;
            int leftHeight = MaxDepth(root.left);
            int rightHeight = MaxDepth(root.right);

            /// <summary>
            /// For IsBalanced recursion I had to google :(
            /// cause my code failed for a tree like this
            ///                 1
            ///              2     2
            ///           3            3
            ///        4                  4
            /// </summary>


            if (Math.Abs(leftHeight - rightHeight) <= 1 && IsBalanced(root.left) && IsBalanced(root.right)) 
                return true;
            return false;
        }
    }
}
