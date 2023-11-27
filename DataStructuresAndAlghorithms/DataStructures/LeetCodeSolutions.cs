namespace DataStructuresAndAlghorithms.DataStructures;

public class LeetCodeSolutions
{
    
}
//
// var l1 = new ListNode
// {
//     val = 3,
//     next = new ListNode
//     {
//         val = 4
//         // next = new ListNode
//         // {
//         //     val = 3
//         // }
//     }
// };
//
// var l2 = new ListNode
// {
//     val = 1,
//     next = new ListNode
//     {
//         val = 3,
//         next = new ListNode
//         {
//             val = 7,
//             next = new ListNode
//             {
//                 val = 9
//             }
//         }
//     }
// };

// var result1 = new Solution().AddTwoNumbers(l1, l2);
// var result2 = new Solution().RemoveNthFromEnd(l1, 2);
// var result3 = new Solution().MergeTwoLists2(l1, l2);
// var result= new Solution().SwapPairs(l2);
// Console.ReadLine();


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
    public ListNode SwapPairs(ListNode head) {
        if(head?.next is null)  {
            return head;
        }
        ListNode response=head;


        while(head?.next!=null){
            (head.val, head.next.val) = (head.next.val, head.val);
            head=head.next.next;
        }
        return response;

    }
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        ListNode fast = head, slow = head;
        for (int i = 0; i < n; i++)
        {
            fast = fast.next;
        }

        if (fast == null)
        {
            return head.next;
        }

        while (fast?.next != null)
        {
            fast = fast.next;
            slow = slow.next;
        }

        slow.next = slow.next.next;
        return head;
    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var response = new ListNode();
        var current = response;
        int carry = 0;
        while (l1?.val != null || l2?.val != null || carry > 0)
        {
            carry += (l1?.val ?? 0) + (l2?.val ?? 0);
            response.next = new ListNode(carry % 10);
            carry /= 10;
            l1 = l1?.next;
            l2 = l2?.next;
            response = response.next;
        }

        return current.next;
    }
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var current = new ListNode();
        var response = current;
        while (list1?.val != null || list2?.val != null)
        {
            if (list2?.val == null || (list1?.val != null && list1.val < list2?.val))
            {
                current.next = new ListNode(list1.val);
                list1 = list1.next;
            }
            else
            {
                current.next = new ListNode(list2.val);
                list2 = list2.next;
            }
            current = current.next;
        }
        return response.next;
    }
    // 1,4   2,3
    public ListNode MergeTwoLists2(ListNode l1, ListNode l2){
        if(l1 == null) return l2;
        if(l2 == null) return l1;
        if(l1.val < l2.val){
            l1.next = MergeTwoLists2(l1.next, l2);
            return l1;
        } else{
            l2.next = MergeTwoLists2(l1, l2.next);
            return l2;
        }
    }
}