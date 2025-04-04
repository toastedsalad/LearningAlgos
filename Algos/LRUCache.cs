using System.Collections.Generic;

namespace LearningAlgos;

public class LRUCache {
    private Dictionary<int, DoublyListNode<(int key, int value)>> dict;
    private int _capacity;
    private DoublyListNode<(int key, int value)> _head;
    private DoublyListNode<(int key, int value)> _tail;

    public LRUCache(int capacity) {
        dict = new Dictionary<int, DoublyListNode<(int key, int value)>>();
        _head = _tail = new DoublyListNode<(int key, int value)>();
        _capacity = capacity;
    }
    
    public int Get(int key) {
        if (dict.TryGetValue(key, out var node)) {
            return node.valueContainer.value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        if (dict.TryGetValue(key, out var node)) {
            // TODO: we touched the value but we did not update 
            // the order of the linked list.
            // Refer to our drawing.
            var current = node;
            var previous = current.prev;
            
            current.next = null;
            current.prev.next = current.next;
            current.prev = _tail;


            previous.next = current.next;

            current.next.prev = current.prev;
            current.next.next = current.next;


            _tail.next = node;
            _tail = node;
            node.valueContainer.value = value;
        } else {
            var newValue = (key, value);
            var newNode = new DoublyListNode<(int key, int value)>(newValue, null!, _tail);
            dict.Add(key, newNode);
            _tail.next = newNode;
            newNode.prev = _tail;
            _tail = newNode;
        }

        if (dict.Count == 1) {
            _head = _tail;
        }

        if (dict.Count > _capacity) {
            var nodeToDelete = _head;
            _head = _head.next;
            nodeToDelete.next = null;
            dict.Remove(nodeToDelete.valueContainer.key); // what do we remove here.
        }

        // The value of the dict could be a reference to a linked list node
        // if (!dict.TryAdd(key, value)) {
        //     dict[key] = value;
        // }
    }
}






