using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ItsLeet.LinkedLists
{
    public class AddNumbers
    {

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            // use stacks to reverse the list values
            // convert to string and parse to int
            // add the two
            // convert to string and make it back to listNode

            Stack<int> l1Stack = new Stack<int>();
            Stack<int> l2Stack = new Stack<int>();
            
            while(l1.next != null)
            {
                l1Stack.Push(l1.val);
                l1 = l1.next;
            }

            l1Stack.Push(l1.val);

            while (l2.next != null)
            {
                l2Stack.Push(l2.val);
                l2 = l2.next;
            }
            
            l2Stack.Push(l2.val);


            StringBuilder sb = new StringBuilder();

            while(l1Stack.Count > 0)
            {
                sb.Append(l1Stack.Pop());
            }
            BigInteger l1Big  = BigInteger.Parse(sb.ToString());
            sb = new StringBuilder();

            while(l2Stack.Count > 0)
            {
                sb.Append(l2Stack.Pop());
            }
            BigInteger l2Big = BigInteger.Parse(sb.ToString());

            BigInteger bigSum = BigInteger.Add(l1Big, l2Big);

            string sumString = bigSum.ToString();

            // form a linked list

            ListNode sumList = new ListNode(sumString[0] - '0');

            for (int i = 1; i < sumString.Length; i++)
            {
                ListNode nextNode = new ListNode(sumString[i] - '0');
                nextNode.next = sumList;
                sumList = nextNode;
            }

            return sumList;
        }
    }
}
