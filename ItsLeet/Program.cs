using ItsLeet.Sorting;
using ItsLeet.LinkedLists;
using System.Diagnostics;


AddNumbers addNumbers = new AddNumbers();

ListNode list = new ListNode(2);
list.next = new ListNode(4);
list.next.next = new ListNode(3);

ListNode list2 = new ListNode(5);
list2.next = new ListNode(6);
list2.next.next  = new ListNode(4);

var result = addNumbers.AddTwoNumbers(list, list2);

while(result.next != null)
{
    Console.Write(result.val);
    result = result.next;
}
Console.Write(result.val);

Console.ReadLine();
