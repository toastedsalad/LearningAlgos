using System;

namespace LearningAlgos;

public class MyRingBuffer {
    private int[] circularArray;
    private int frontIndex;
    private int rearIndex;

    public MyRingBuffer(int k) {
        // When we initialize we should initialize an array
        // of size k;
        circularArray = new int[k];
        // When we initialize we can set Front and Rear
        frontIndex = rearIndex = 0;
    }

    public bool EnQueue(int value) {
        if (IsFull()) {
            return false;
        }

        circularArray[rearIndex] = value;
        rearIndex = (rearIndex + 1) % circularArray.Length;
        return true;
    }

    public bool DeQueue() {
        frontIndex++;
        return true;
    }

    public int Front() {
        if (IsEmpty()) {
            return -1;
        }
        return circularArray[frontIndex];
    }

    public int Rear() {
        if (IsEmpty()) {
            return -1;
        }
        return circularArray[rearIndex];
    }

    public bool IsEmpty() {
        if (frontIndex == rearIndex) {
            return true;
        }
        //        ht
        // [1, 2, 3]
        return false;
    }

    public bool IsFull() {
        //  h        t       4 % 5 = 1
        // [1, 2, 3, 4]
        // if tail + 1 is head then array is full
        // if we enque and the resulting index is head then the queu is full
        //
        //     t  h          4 % 5 = 1
        // [1, 2, 3, 4]

        if ((rearIndex + 1) % circularArray.Length == frontIndex) {
            return true;
        }

        return false;
        // var size = Math.Abs(rearIndex - frontIndex);
        // return size == circularArray.Length;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */

/**
  MyCircularQueue(k) Initializes the object with the size of the queue to be k.
  int Front() Gets the front item from the queue. If the queue is empty, return -1.
  int Rear() Gets the last item from the queue. If the queue is empty, return -1.
  boolean enQueue(int value) Inserts an element into the circular queue. Return true if the operation is successful.
  boolean deQueue() Deletes an element from the circular queue. Return true if the operation is successful.
  boolean isEmpty() Checks whether the circular queue is empty or not.
  boolean isFull() Checks whether the circular queue is full or not.
  */




