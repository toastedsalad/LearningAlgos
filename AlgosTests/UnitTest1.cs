using LearningAlgos;

namespace AlgosTests{
    public class Tests{
        [SetUp]
        public void Setup(){
        }

        [Test]
        public void NewArrayRetursnEmpty(){
            // Randomize the argument? So that it isn't always one?
            var queue = new MyRingBuffer(1);
            var front = queue.Front();
            Assert.That(front, Is.EqualTo(-1));
        }

        [Test]
        public void EmptyReturnMinusOne()
        {
            var queue = new MyRingBuffer(1);
            var empty = queue.IsEmpty();
            Assert.That(empty, Is.EqualTo(true));
        }
    }
}

