/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     int val;
 *     ListNode next;
 *     ListNode() {}
 *     ListNode(int val) { this.val = val; }
 *     ListNode(int val, ListNode next) { this.val = val; this.next = next; }
 * }
 */
class Solution {
    public ListNode removeNthFromEnd(ListNode head, int n) {
        int size = 1;
        for (ListNode ln = head; ln.next != null; ln = ln.next) {
            size++;
        }
        int target = size - n;
        int index = 0;

        ListNode temp = head, prev = null;
        if (temp != null && index == target) {
            head = temp.next; // if we find it in the first spot
            return head;
        }

        while (temp != null && index != target) {
            prev = temp; // store prev
            temp = temp.next; // iterate to next val until we find n
            index++;
        }

        if (temp == null) {
            return head; // the value was not found in the list
        }

        prev.next = temp.next; // we found the value and it is in the temp node
        return head;
    }
}
