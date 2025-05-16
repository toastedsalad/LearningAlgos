namespace LearningAlgos;

public class MyHashMap {
    private LinkedNode<(int, int)>[] underlyingArray;

    public MyHashMap() {
        underlyingArray = new LinkedNode<(int, int)>[100];
    }
    
    public void Put(int key, int value) {
        int ind = GetIndex(key);

        var node = new LinkedNode<(int, int)>((key, value));
        node.NodeData = (key, value);
        underlyingArray[ind] = node;
    }

    public int Get(int key) {
        int ind = GetIndex(key);
        
        if (underlyingArray[ind] == default!) {
            return -1;
        }

        var currentNode = underlyingArray[ind];
        while (currentNode != null) {}
        return -1;
    }
    
    public void Remove(int key) {
        int ind = GetIndex(key);
        // underlyingArray[ind] = -1;
    }

    private int GetIndex(int key) {
        var keyHash = key.GetHashCode();
        var ind = keyHash % underlyingArray.Length;
        return ind;
    }
}
