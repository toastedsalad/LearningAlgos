namespace LearningAlgos;


public class AddTwoIntsLinkeList {
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var addedLL = new ListNode();
        var current = addedLL;
        var currentl1 = l1;
        var currentl2 = l2;
        var carry = 0;

        while (currentl1 != null && currentl2 != null) {
            // 9 + 1 + 0 = 10
            current.val = currentl1.val + currentl2.val + carry;
            carry = 0;

            if (currentl1.next == null && currentl2.next == null) {
                if (current.val == 10) {
                    current.val = 0;
                    current.next = new ListNode();
                    current.next.val = 1;
                    return addedLL;
                }

                if (current.val > 10) {
                    current.val = current.val - 10;
                    current.next = new ListNode();
                    current.next.val = 1;
                    return addedLL;
                }
            }

            if (current.val == 10) {
                current.val = 0;
                carry = 1;
            }

            if (current.val > 10) {
                current.val = current.val - 10;
                carry = 1;
            }

            // Here we say that if the .next in the lists we are adding
            // are not zero. Then we'll need another nother element in our List.
            if (currentl1.next != null && currentl2.next != null) {
                current.next = new ListNode();
                current = current.next;
            }

            // What happens if one of the lists is empty but 
            // another has 9 and we carry 1?
            if (currentl1.next != null && currentl2.next == null) {
                current.next = new ListNode();
                currentl2.next = new ListNode();
                current = current.next;
            }

            if (currentl2.next != null && currentl1.next == null) {
                current.next = new ListNode();
                currentl1.next = new ListNode();
                current = current.next;
            }

            currentl1 = currentl1.next;
            currentl2 = currentl2.next;
        }

        return addedLL;
    }
} 
