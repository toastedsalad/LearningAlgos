using System.Collections.Generic;

namespace LearningAlgos;

public class LRUCache {
    private Dictionary<int, DoublyListNode> dict;
    private int _capacity;
    private DoublyListNode _head;
    private DoublyListNode _tail;

    public LRUCache(int capacity) {
        dict = new Dictionary<int, DoublyListNode>();
        _head = _tail = new DoublyListNode();
        _capacity = capacity;
    }
    
    public int Get(int key) {
        if (dict.TryGetValue(key, out var node)) {
            return node.value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if (dict.TryGetValue(key, out var node)) {
            // TODO: we touched the value but we did not update 
            // the order of the linked list.
            // Refer to our drawing.
            node.value = value;
        }
        else {
            var newNode = new DoublyListNode(value, null!, _tail);
            dict.Add(key, newNode);
            _tail.next = newNode;
            _tail = newNode;
        }

        // // The value of the dict could be a reference to a linked list node
        // if (!dict.TryAdd(key, value)) {
        //     dict[key] = value;
        // }
    }
}






