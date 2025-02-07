using System.Collections.Generic;

namespace LearningAlgos;

public class LRUCache {
    private Dictionary<int, int> dict;
    private Queue<int> _tmpQueue;
    private int _capacity;

    public LRUCache(int capacity) {
        dict = new Dictionary<int, int>();
        _tmpQueue = new Queue<int>();
        _capacity = capacity;
    }
    
    public int Get(int key) {
        if (dict.TryGetValue(key, out var value)) {
            return value;
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
        
        _tmpQueue.Enqueue(key);
 
        if (_tmpQueue.Count > _capacity) {
            var oldestKey = _tmpQueue.Dequeue();
            dict.Remove(oldestKey);
        }

        if (!dict.TryAdd(key, value)) {
            dict[key] = value;
        }
    }
}








