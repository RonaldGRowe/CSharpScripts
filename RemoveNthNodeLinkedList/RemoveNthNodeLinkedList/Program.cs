//Uses less memory than over 99% of solutions, but only faster than 44%.




// Definition for singly - linked list.
  public class ListNode
{
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
             }
  }

public class Solution
{
    public static ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var listLength = 0;
        ListNode node = head;
        ListNode nextNode = node;

        //Count list, number of nodes
        while (nextNode != null)
        {
            listLength++;
            nextNode = nextNode.next;
        }

        //Determine how far to cycle to find node to delete
        var cycle = listLength - n;
        nextNode = head;
        ListNode prevNode = head.next;
        //If we need to remove head node
        if (cycle == 0)
        {
            head = head.next;
            return head;
        }

        //Cycle through list to grab previous node
        //Possibly use a stack to save nodes then pop off n times, to shorten run time
        for (var i = 0; i < cycle; i++)
        {

            if (i == cycle - 1)
            {
                prevNode = nextNode;
            }
            nextNode = nextNode.next;
        }

        prevNode.next = nextNode.next;

        return head;
    }
}