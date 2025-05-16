using LearningAlgos;

namespace AlgosTests;

public class LRUCacheTests {

    [Test]
    public void PutAndGetOneItemReturnsItem() {
        var cache = new LRUCache(2);
        cache.Put(1, 1);
        Assert.That(cache.Get(1), Is.EqualTo(1));
    }

    [Test]
    public void GetNotExistentReturnsMinusOne() {
        var cache = new LRUCache(2);
        Assert.That(cache.Get(1), Is.EqualTo(-1));
    }

    [Test]
    public void PutSameKeyTwiceReturnsLatest() {
        var cache = new LRUCache(2);
        cache.Put(1, 1);
        cache.Put(1, 2);
        Assert.That(cache.Get(1), Is.EqualTo(2));
    }

    [Test]
    public void OldItemGetsEvictedOnNewPut() {
        var cache = new LRUCache(1);
        cache.Put(1, 1);
        cache.Put(2, 2);
        Assert.That(cache.Get(2), Is.EqualTo(2));
        Assert.That(cache.Get(1), Is.EqualTo(-1));
    }

    [Test]
    public void AddingOverCapacityDoesEviction() {
        var cache = new LRUCache(2);
        cache.Put(1, 1);
        cache.Put(2, 2);
        cache.Put(3, 3);
        Assert.That(cache.Get(3), Is.EqualTo(3));
        Assert.That(cache.Get(2), Is.EqualTo(2));
        Assert.That(cache.Get(1), Is.EqualTo(-1));
    }

    // Now this is failing.
    [Test]
    public void SameKeyOverride() {
        var cache = new LRUCache(2);
        cache.Put(1, 1); // add ok
        cache.Put(2, 2); // add ok
        cache.Put(1, 2); // override
        cache.Put(3, 3); // should evict 2, 2
        Assert.That(cache.Get(3), Is.EqualTo(3));
        Assert.That(cache.Get(2), Is.EqualTo(-1));
        Assert.That(cache.Get(1), Is.EqualTo(2));
    }

    [Test]
    public void GettingItemPutsItAsMostRecentlyUsed() {
        var cache = new LRUCache(2);
        cache.Put(1, 1); // add ok
        cache.Put(2, 2); // add ok
        cache.Get(1);
        cache.Put(3, 3); // add ok

        Assert.That(cache.Get(2), Is.EqualTo(-1));
        Assert.That(cache.Get(1), Is.EqualTo(1));
        Assert.That(cache.Get(3), Is.EqualTo(3));
    }

    [Test]
    public void GetFromEmptyCacheReturnsMinusOne() {
        var cache = new LRUCache(2);

        Assert.That(cache.Get(1), Is.EqualTo(-1));
    }

    // ["LRUCache","put","get","put","get","get"]
    // [[1],[2,1],[2],[3,2],[2],[3]]

    [Test]
    public void FromLeetCodeCapacity1AndOverflowBy1() {
        var cache = new LRUCache(1);
        cache.Put(2, 1);
        cache.Get(2);
        cache.Put(3, 2);
        cache.Get(2);
        cache.Get(3); 

        Assert.That(cache.Get(3), Is.EqualTo(2));
    }

    // [Test]
    // // Continue work from this failing test.
    // public void OverrideStraightAfterPut() {
    //     var cache = new LRUCache(2);
    //     cache.Put(2, 2); 
    //     cache.Put(1, 1); 
    //     cache.Put(1, 2); 
    //     Assert.That(cache.Get(2), Is.EqualTo(2)); // this is failing
    //     Assert.That(cache.Get(1), Is.EqualTo(2));
    // }
}





