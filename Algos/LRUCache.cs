using System.Collections.Generic;

namespace LearningAlgos;

public class DoublyListNode<T> {
    public T valueContainer;
    public DoublyListNode<T> next;
    public DoublyListNode<T> prev;
    public DoublyListNode(T val = default!, DoublyListNode<T> next = null!, DoublyListNode<T> prev = null!) {
        this.valueContainer = val;
        this.next = next;
        this.prev = prev;
    }
}

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
            if (dict.Count > 1) {
                RelinkRecentlyUsed(node);
            }
            return node.valueContainer.value;
        }

        return -1;
    }
    
    public void Put(int key, int value) {
        if (dict.TryGetValue(key, out var node)) {
            DoublyListNode<(int key, int value)> current = RelinkRecentlyUsed(node);
            current.valueContainer.value = value;
        } else {
            var newValue = (key, value);
            var newNode = new DoublyListNode<(int key, int value)>(newValue, null!, _tail);
            dict.Add(key, newNode);
            _tail.next = newNode;
            newNode.prev = _tail;
            _tail = newNode;
        }

        if (dict.Count > _capacity) {
            var nodeToDelete = _head.next;
            _head.next = nodeToDelete.next;
            nodeToDelete.next = null;
            dict.Remove(nodeToDelete.valueContainer.key); // what do we remove here.
        }
    }

    private DoublyListNode<(int key, int value)> RelinkRecentlyUsed(DoublyListNode<(int key, int value)> node)
    {
        // Capture references
        var current = node;
        var previous = current.prev;

        // Relink what is behind current
        // to what is in front of current
        // N1 -> N2 -> N3
        // N1 -> N3 -> N2
        previous.next = current.next;

        if (current.next != null) {
            current.next.prev = previous;
        }

        // Managing tail
        previous = _tail;
        _tail.next = current;
        _tail = current;
        current.next = null;
        return current;
    }
}






