using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.Tree
{

    internal class SameTreeAlgorithm
    {
        public bool IsSameTree(TreeNode? p, TreeNode? q)
        {
            Queue<TreeNode?> pQueue = new Queue<TreeNode?>();
            Queue<TreeNode?> qQueue = new Queue<TreeNode?>();

            pQueue.Enqueue(p);
            qQueue.Enqueue(q);

            while(pQueue.Count > 0 && qQueue.Count > 0)
            {
                TreeNode? pnode = pQueue.Dequeue();
                TreeNode? qnode = qQueue.Dequeue();

                if (pnode == null && qnode == null)
                    continue;
                else if ((pnode == null && qnode != null) || ((pnode != null && qnode == null)))
                    return false;

                
                if (pnode.val != qnode.val)
                    return false;

                pQueue.Enqueue(pnode.left);
                qQueue.Enqueue(qnode.left);
                pQueue.Enqueue(pnode.right);
                qQueue.Enqueue(qnode.right);
            }
            return pQueue.Count == qQueue.Count;
        }

    }
}
