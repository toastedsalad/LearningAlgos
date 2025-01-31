using System.Collections.Generic;

namespace LearningAlgos;

public class LRUCache {
    private Dictionary<int, int> dict;
    private int _capacity;

    public LRUCache(int capacity) {
        dict = new Dictionary<int, int>();
        _capacity = capacity;
    }
    
    public int Get(int key) {
        if (dict.TryGetValue(key, out var value)) {
            return value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        // When we put we need to check if we exceed the capacity
        // And if we do we need to trigger the eviction process.
        // How can we be less brutal?
        // Perhaps an extra data structure to keep track of 
        // recently touched items.
        if (dict.Count == _capacity) {
            dict.Clear();
        }

        if (!dict.TryAdd(key, value)) {
            dict[key] = value;
        }
    }
}

