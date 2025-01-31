using LearningAlgos;

namespace AlgosTests {
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
    }
}
