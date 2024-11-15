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
        public void EmptyBufferReturnsIsEmptyTrue(){
            var queue = new MyRingBuffer(1);
            var empty = queue.IsEmpty();
            Assert.That(empty, Is.EqualTo(true));
        }

        [Test]
        public void IsEmptyReturnsFalseWhenArrayIsNotEmpty(){
            var queue = new MyRingBuffer(2);
            queue.EnQueue(someValue);
            var empty = queue.IsEmpty();
            Assert.That(empty, Is.EqualTo(false));
        }
    }
}

