namespace LearningAlgos;

public class LinkedListReverser {
    public ListNode ReverseList(ListNode head) {
        ListNode previous = null; // new head
        ListNode current = head;

        while (current != null) {
            var nextNode = current.next; 
            current.next = previous; 
            previous = current; 
            current = nextNode; 
        }

        return previous; 
    }    
}


//so for me the crucial bit for this reverser problem was visualizing how the reversing happens:
//
//I first tried going from this:
//
//H1 > 2 > 3 > 4
//
//to this and it led me some weird directions
//
//H4 > 3 > 2 > 1
//
//when actually what i need to do is this:
//
//
//1 < 2 < 3 < 4H
