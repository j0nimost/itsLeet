using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.LinkedLists
{
    public class RotateLinkedList
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            // rotate by k steps
            // get last listNode
            //mark next as head

            List<ListNode> listNodes = new List<ListNode>();
            // get last node

            if (head == null)
                return null;

            while (head.next != null)
            {
                listNodes.Add(head);
                head = head.next;
            }
            
            listNodes.Add((ListNode)head);

            // rotate array
            k = k % listNodes.Count;

            RotateList(listNodes, 0, listNodes.Count-1);
            RotateList(listNodes, 0, k-1);
            RotateList(listNodes, k, listNodes.Count-1);

            ListNode resultNode = null;

            for (int i = listNodes.Count-1; i >=0; i--)
            {
                listNodes[i].next = null;

                if (resultNode == null)
                {
                    resultNode = new ListNode(listNodes[i].val, null);
                }
                else
                {
                    ListNode newNode = new ListNode(listNodes[i].val, null);
                    newNode.next = resultNode;
                    resultNode = newNode;
                }
            }
            
            return resultNode;
        }

        public static void RotateList(List<ListNode> nodes, int start, int last)
        {
            while(last > start)
            {
                var temp = nodes[start];
                nodes[start] = nodes[last];
                nodes[last] = temp;

                start++;
                last--;
            }
        }
    }
}
