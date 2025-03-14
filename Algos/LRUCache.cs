using System.Collections.Generic;

namespace LearningAlgos;

public class LRUCache {
    private Dictionary<int, ListNode> dict;
    private Queue<int> _tmpQueue;
    private int _capacity;
    private ListNode _head;
    private ListNode _tail;

    public LRUCache(int capacity) {
        dict = new Dictionary<int, ListNode>();
        _tmpQueue = new Queue<int>();
        _head = _tail = new ListNode();
        _capacity = capacity;
    }
    
    public int Get(int key) {
        if (dict.TryGetValue(key, out var node)) {
            return node.value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        // The problem is that we can't traverse the queue
        // to manage items in the middle of the queue
        //
        // We probably need a LinkedList and then iterate over it.
        // The Linked List is available in the solution
        // var LinkedList = new ListNode();

        if (dict.TryGetValue(key, out var node)) {
            node.value = value;
        }
        else {
            var newNode = new ListNode(value);
            dict.Add(key, newNode);
            _tail.next = newNode;
            _tail = newNode;
        }
        
        // We always enqueue...
        _tmpQueue.Enqueue(key);
        // We should add values conditionally...
 
        if (_tmpQueue.Count > _capacity) {
            var oldestKey = _tmpQueue.Dequeue();
            dict.Remove(oldestKey);
        }

        // // The value of the dict could be a reference to a linked list node
        // if (!dict.TryAdd(key, value)) {
        //     dict[key] = value;
        // }
    }
}






