using LearningAlgos;

namespace AlgosTests{
    public class Tests{
        const int someValue = 7;

        [Test]
        public void NewBufferRetursnEmpty() {
            // Randomize the argument? So that it isn't always one?
            var queue = new MyRingBuffer(1);
            var front = queue.Front();
            Assert.That(front, Is.EqualTo(-1));
        }

        [Test]
        public void FrontReturnsFrontValueOfTheArray() {
            // Randomize the argument? So that it isn't always one?
            var queue = new MyRingBuffer(2);
            queue.EnQueue(someValue);
            var front = queue.Front();
            Assert.That(front, Is.EqualTo(someValue));
        }

        [Test]
        public void WhenCapacityIsFullEnqueueReturnsFalse() {
            //  ht 
            // [ , , ]
            var queue = new MyRingBuffer(3);
            //
            //  h   t
            // [1,2,3]
            Assert.That(queue.EnQueue(someValue), Is.True);
            Assert.That(queue.EnQueue(someValue), Is.True);
            Assert.That(queue.EnQueue(someValue), Is.True);
            // Try enqueu at full capacity
            Assert.That(queue.EnQueue(someValue), Is.False);
        }

        [Test]
        public void EnqueWorkInACircularWay() {
            //  ht 
            // [ , , ]
            var queue = new MyRingBuffer(3);
            //
            //  h   t
            // [1,2,3]
            Assert.That(queue.EnQueue(someValue), Is.True);
            Assert.That(queue.EnQueue(someValue + 1), Is.True);
            Assert.That(queue.EnQueue(someValue + 2), Is.True);
            //     ht
            // [1,2,3]
            Assert.That(queue.DeQueue(), Is.True);
            Assert.That(queue.Front(), Is.EqualTo(someValue + 1));
            Assert.That(queue.DeQueue(), Is.True);
            Assert.That(queue.Front(), Is.EqualTo(someValue + 2));
            //  t   h
            // [4,5,3]
            Assert.That(queue.EnQueue(someValue), Is.True);
        }

        [Test]
        public void DequeWorksInACircularWay() {
            //  ht 
            // [ , , ]
            var queue = new MyRingBuffer(3);
            //
            //  h   t
            // [1,2,3]
            Assert.That(queue.EnQueue(1), Is.True);
            Assert.That(queue.EnQueue(2), Is.True);
            Assert.That(queue.EnQueue(3), Is.True);
            //     ht
            // [1,2,3]
            Assert.That(queue.DeQueue(), Is.True);
            Assert.That(queue.Front(), Is.EqualTo(2));
            Assert.That(queue.DeQueue(), Is.True);
            Assert.That(queue.Front(), Is.EqualTo(3));
            
            //    t h
            // [4,5,3]
            Assert.That(queue.EnQueue(4), Is.True);
            Assert.That(queue.Rear(), Is.EqualTo(4));
            Assert.That(queue.EnQueue(5), Is.True);
            Assert.That(queue.Rear(), Is.EqualTo(5));

            //  h t      
            // [4,5,3]
            Assert.That(queue.DeQueue(), Is.True);
            Assert.That(queue.Front(), Is.EqualTo(4));
        }

        [Test]
        public void EnqueAndDequeuWithCapacityOneWorks() {
            var queue = new MyRingBuffer(1);
            queue.EnQueue(1);
            Assert.That(queue.Front(), Is.EqualTo(1));
            Assert.That(queue.Rear(), Is.EqualTo(1));
            Assert.That(queue.EnQueue(2), Is.False);
            Assert.That(queue.DeQueue(), Is.True);
            Assert.That(queue.IsEmpty(), Is.True);
        }

        [Test]
        public void LeetCodeProblem1() {
            var queue = new MyRingBuffer(81);
            queue.EnQueue(69);
            Assert.That(queue.Front(), Is.EqualTo(69));
            //   fr
            // [ 69, 0, 0 , 0]
            //
            queue.DeQueue();
            //   r   f
            // [ 69, 0, 0 , 0]
            //
            Assert.That(queue.Front(), Is.EqualTo(-1));
            Assert.That(queue.IsEmpty(), Is.True);
            queue.EnQueue(92);
            Assert.That(queue.Front(), Is.EqualTo(92));
        }

        [Test]
        public void WhenEnqueOverflowsGoAroundTheArray() {
            var queue = new MyRingBuffer(3);
            queue.EnQueue(someValue);
            queue.EnQueue(someValue);
            queue.EnQueue(someValue + 1);

            queue.DeQueue();
            queue.DeQueue();

            queue.EnQueue(someValue + 2); // This should be at array[0]
            Assert.That(queue.Front, Is.EqualTo(someValue + 1));
            Assert.That(queue.Rear, Is.EqualTo(someValue + 2));
        }

        [Test]
        public void DequeOnEmptyReturnsFalse() {
            var queue = new MyRingBuffer(2);
            Assert.That(queue.DeQueue(), Is.False);
        }

        [Test]
        public void DequeRemovesFrontAndReturnsTrue() {
            // Randomize the argument? So that it isn't always one?
            // Assert that after deque the rear is rear - 1
            var queue = new MyRingBuffer(2);
            queue.EnQueue(someValue);
            // h    t
            // [7, 0]
            var dequeResult = queue.DeQueue();
            //     ht
            // [7, 0]
            Assert.That(dequeResult, Is.EqualTo(true));
            Assert.That(queue.IsEmpty(), Is.EqualTo(true));
            Assert.That(queue.Front(), Is.EqualTo(-1));
            Assert.That(queue.Rear(), Is.EqualTo(-1));
        }

        [Test]
        // Add queue and dequeue and then test for emptiness.
        public void FrontReturnsMinusOneWhenEmpty() {
            // Randomize the argument? So that it isn't always one?
            var queue = new MyRingBuffer(2);
            var front = queue.Front();
            Assert.That(front, Is.EqualTo(-1));
        }

        [Test]
        public void EmptyBufferReturnsIsEmptyTrue() {
            var queue = new MyRingBuffer(1);
            var empty = queue.IsEmpty();
            Assert.That(empty, Is.EqualTo(true));
        }

        [Test]
        public void IsEmptyReturnsFalseWhenArrayIsNotEmpty() {
            var queue = new MyRingBuffer(2);
            queue.EnQueue(someValue);
            var empty = queue.IsEmpty();
            Assert.That(empty, Is.EqualTo(false));
        }

        [Test]
        public void CircularBufferIsFull() {
            var queue = new MyRingBuffer(3);
            queue.EnQueue(someValue);
            queue.EnQueue(someValue);
            queue.EnQueue(someValue);

            var isFull = queue.IsFull();
            Assert.That(isFull, Is.EqualTo(true));
        }

        [Test]
        public void CircularBufferIsFullReturnsFalseWhenNotFull() {
            var queue = new MyRingBuffer(3);
            queue.EnQueue(someValue);
            queue.EnQueue(someValue);

            var isFull = queue.IsFull();
            Assert.That(isFull, Is.EqualTo(false));
        }

        [Test]
        public void WhenBufferNotEmptyRearReturnsTheLastValue() {
            var queue = new MyRingBuffer(3);
            queue.EnQueue(someValue);
            queue.EnQueue(someValue + 1);

            Assert.That(queue.Rear(), Is.EqualTo(someValue + 1));
        }

        [Test]
        public void WhenBufferNotEmptyFrontReturnsTheFirstValue() {
            var queue = new MyRingBuffer(3);
            queue.EnQueue(someValue);
            queue.EnQueue(someValue + 1);

            Assert.That(queue.Front(), Is.EqualTo(someValue));
        }
    }
}

