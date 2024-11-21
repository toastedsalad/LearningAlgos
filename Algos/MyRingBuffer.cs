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
        }

        public bool EnQueue(int value) {
            circularArray[rearIndex] = value;
            rearIndex++;
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
            return 0;
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
            //  t  h  
            // [1, 2, 3]
            // if tail + 1 is head then array is full
            return true;
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



