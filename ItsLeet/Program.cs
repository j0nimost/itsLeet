using ItsLeet.Sorting;
using ItsLeet.LinkedLists;
using System.Diagnostics;

RotateLinkedList RotateLinkedList = new RotateLinkedList();
ListNode list = new ListNode(1);
list.next = new ListNode(2);
list.next.next = new ListNode(3);
list.next.next.next = new ListNode(4);
list.next.next.next.next = new ListNode(5);

var result = RotateLinkedList.RotateRight(list, 2);

while(result.next != null)
{
    Console.Write(result.val + "->");
    result = result.next;
}
Console.Write(result.val);

Console.ReadLine();
