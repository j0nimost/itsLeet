using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.LinkedLists
{
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            // iterate through the listNode
            // store values 

            HashSet<ListNode> visited = new HashSet<ListNode>();

            if(head == null) 
                return false;

            while(head.next != null)
            {

                if (!visited.Add(head))
                    return true;
                head = head.next;
            }


            return false;
        }
    }
}
