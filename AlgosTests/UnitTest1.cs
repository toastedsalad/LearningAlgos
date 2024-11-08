namespace AlgosTests;

public class Tests{
    [SetUp]
    public void Setup(){
    }

    [Test]
    public void NewArrayRetursnEmpty(){
        var queue = new MyCircularQueue();
        var front = queue.Front()
            Assert.That(front isEqual(-1));
    }

    [Test]
    public void EmptyReturnMinusOne()
    {
        var queue = new MyCircularQueue();
        var empty = queue.IsEmpty();
        Assert.That(empty isEqual(true));
    }
}
