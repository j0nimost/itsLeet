namespace ItsLeet.LinkedLists;

public class RemoveDuplicatesFromList
{
    public ListNode DeleteDuplicates(ListNode head) {
        var headRef = head;
        while (headRef != null)
        {
            var next = headRef.next;
            while (next != null && headRef.val == next.val)
            {
                next = next.next;
            }
            headRef.next = next;
            headRef = headRef.next;
        }
        return head;
    }
}