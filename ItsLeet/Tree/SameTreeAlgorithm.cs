using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.Tree
{

    internal class SameTreeAlgorithm
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            Queue<TreeNode> p_queue = new Queue<TreeNode>();
            Queue<TreeNode> q_queue = new Queue<TreeNode>();

            p_queue.Enqueue(p);
            q_queue.Enqueue(q);

            while(p_queue.Count > 0 && q_queue.Count > 0)
            {
                TreeNode pnode = p_queue.Dequeue();
                TreeNode qnode = q_queue.Dequeue();

                if (pnode == null && qnode == null)
                    continue;
                else if ((pnode == null && qnode != null) || ((pnode != null && qnode == null)))
                    return false;

                
                if (pnode.val != qnode.val)
                    return false;

                p_queue.Enqueue(pnode.left);
                q_queue.Enqueue(qnode.left);
                p_queue.Enqueue(pnode.right);
                q_queue.Enqueue(qnode.right);
            }
            return p_queue.Count == q_queue.Count;
        }

    }
}
