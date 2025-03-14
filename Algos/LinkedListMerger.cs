namespace LearningAlgos;

public class LinkedListMerger {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode mergedList = new ListNode();

        if (list1 == null && list2 == null) {
            return null;
        }

        if (list1 == null) {
            return list2;
        }

        if (list2 == null) {
            return list1;
        }

        // Found it's a good practice to just keep a redcord of heads
        var currentNode = mergedList;
        // Doesn't work if I get lists containing one node
        var currentList1 = list1;
        var currentList2 = list2;

        while (currentList1 != null && currentList2 != null) {
            if (currentList1.value <= currentList2.value) {
                currentNode.next = currentList1;
                currentList1 = currentList1.next;
            }
            else {
                currentNode.next = currentList2;
                currentList2 = currentList2.next;
            }

            currentNode = currentNode.next;
        }

        // Add attach remaining nodes
        if (currentList1 == null) {
            currentNode.next = currentList2;
        }
        
        if (currentList2 == null) {
            currentNode.next = currentList1;
        }

        // Unlink the first node
        var finalMerge = mergedList.next;
        // Let GC deal with the empty first node.
        mergedList.next = null;

        return finalMerge;
    }
}

