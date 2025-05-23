namespace LearningAlgos;

public class NodePriv<T> {
    public T Value { get; set; }
    public NodePriv<T>? NextNode { get; set; }

    public NodePriv(T value, NodePriv<T>? nextNode = null){
        Value = value;
        NextNode = nextNode;
    }
}

public class MyLinkedList {
    private NodePriv<int>? _head;
    private NodePriv<int>? _tail;
    public int Length { get; private set; }

    public MyLinkedList() {
        _head = _tail = null;
        Length = 0;
    }

    public int Get(int index) {
        if (Length == 0) {
            return -1;
        }

        var current = _head;
        for (var i = 0; i < Length; i++) {
            if (i == index) {
                return current.Value;
            }
            current = current.NextNode;
        }

        return -1;
    }

    public void AddAtTail(int val) {
        var item =  new NodePriv<int>(val);
        if (Length == 0){
            _head = item;
            _tail = _head;
            Length++;
        }
        else {
            _tail.NextNode = item;
            _tail = item;
            Length++;
        }
    }

    public void AddAtHead(int val) {
        var item =  new NodePriv<int>(val);
        if (Length == 0){
            _head = item;
            _tail = _head;
            Length++;
        }
        else {
            item.NextNode = _head;
            _head = item;
            Length++;
        }
    }

    public void AddAtIndex(int index, int val) {
        var item =  new NodePriv<int>(val);
        if (index == 0 && Length == 0){
            _head = item;
            _tail = _head;
            Length++;
            return;
        }

        if (index == Length) {
            _tail.NextNode = item;
            _tail = item;
            Length++;
            return;
        }

        var current = _head;
        var previous = _head;
        for (var i = 0; i < Length; i++) {
            if (i == index) {
                previous.NextNode = item;
                item.NextNode = current;
                Length++;
                return;
            }
            previous = current;
            current = current.NextNode;
        }
    }

    public void DeleteAtIndex(int index) {
        if (index > Length) {
            return;
        }

        if (Length == -1) {
            return;
        }

        var current = _head;
        var previous = _head;
        for (var i = 0; i < Length; i++) {
            if (i == index) {
                // If we are deleteing at the start or end
                // We need to repoint the head and tail pointers
                previous.NextNode = current.NextNode;
                Length--;
                return;
            }
            previous = current;
            current = current.NextNode;
        }
    }
}








