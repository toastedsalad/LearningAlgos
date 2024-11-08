namespace LearningAlgos{
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
            circularArray[frontIndex] = -1;
        }

        public bool EnQueue(int value) {

        }

        public bool DeQueue() {

        }

        public int Front() {
            return k[frontIndex];
            // And if it is empty, we need to return -1.
        }

        public int Rear() {

        }

        public bool IsEmpty() {

        }

        public bool IsFull() {

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
}



