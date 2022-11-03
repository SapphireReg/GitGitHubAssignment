using DoublyLinkedListWithErrors;

namespace DLLSoftwareTesting
{
    [TestClass]
    public class UnitTest1
    {
        //DLL Node Test

        [TestMethod]
        public void DLLNodeTest() //test node creation
        {
            DLLNode a = new DLLNode(1);
            Assert.AreEqual(a.num, 1);
            Assert.IsNull(a.next);
            Assert.IsNull(a.previous);
        }

        [TestMethod]
        public void isPrimeTest() //test if 3 node.num is prime = True
        {
            DLLNode a = new DLLNode(3);
            Assert.IsTrue(a.isPrime());
        }

        [TestMethod]
        public void isPrimeTestOne() //test if 1 node.num is prime = False
        {
            DLLNode a = new DLLNode(1);
            Assert.IsFalse(a.isPrime());
        }

        [TestMethod]
        public void isPrimeTestHighTrue() //test if 13 node.num is prime = True
        {
            DLLNode a = new DLLNode(13);
            Assert.IsTrue(a.isPrime());
        }

        [TestMethod]
        public void isPrimeTestHighFalse() //test if 13 node.num is prime = True
        {
            DLLNode a = new DLLNode(49);
            Assert.IsFalse(a.isPrime());
        }

        //DLL method tests

        [TestMethod]
        public void AddToHeadTestOne() //add to head from null list
        {
            DLLNode a = new DLLNode(33);
            DLList list = new DLList();
            list.addToHead(a);
            Assert.AreEqual(list.head, a);
        }

        [TestMethod]
        public void AddtoHeadTestTwo() //add to head 3x 
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);
            DLList list = new DLList();
            list.addToHead(a);
            list.addToHead(b);
            list.addToHead(c);
            Assert.AreEqual(list.head, c);
            Assert.AreEqual(list.head.next, b);
            Assert.AreEqual(list.head.next.next, a);
        }

        [TestMethod]
        public void AddToTailTestOne() //add to tail from null list
        {
            DLLNode a = new DLLNode(1);
            DLList list = new DLList();
            list.addToTail(a);
            Assert.AreEqual(list.tail, a);
        }

        [TestMethod]
        public void AddToTailTestTwo() //add to tail 3x
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);
            DLList list = new DLList();
            list.addToTail(a);
            list.addToTail(b);
            list.addToTail(c);
            Assert.AreEqual(list.tail, c);
            Assert.AreEqual(list.tail.previous, b);
            Assert.AreEqual(list.tail.previous.previous, a);
        }

        [TestMethod]
        public void AddToTailHeadTest() //add to tail and head 2x each [d,b,a,c]
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);
            DLLNode d = new DLLNode(4);
            DLList list = new DLList();
            list.addToTail(a);
            list.addToHead(b);
            list.addToTail(c);
            list.addToHead(d);
            Assert.AreEqual(list.head, d);
            Assert.AreEqual(list.tail, c);
            Assert.AreEqual(list.head.next, b);
            Assert.AreEqual(list.tail.previous, a);
        }

        [TestMethod]
        public void RemoveHead() //Remove 1Head [d,b,a,c] -> [b,a,c]
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);
            DLLNode d = new DLLNode(4);
            DLList list = new DLList();
            list.addToTail(a);
            list.addToHead(b);
            list.addToTail(c);
            list.addToHead(d);
            list.removeHead();
            Assert.AreEqual(list.head, b);
            Assert.AreEqual(list.tail, c);
            Assert.AreEqual(list.head.next, a);
        }

        [TestMethod]
        public void RemoveHeadTwo() //Remove 2 Head [d,b,a,c] -> [a,c]
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);
            DLLNode d = new DLLNode(4);
            DLList list = new DLList();
            list.addToTail(a);
            list.addToHead(b);
            list.addToTail(c);
            list.addToHead(d);
            list.removeHead();
            list.removeHead();
            Assert.AreEqual(list.head, a);
            Assert.AreEqual(list.head.next, c);
        }

        [TestMethod]
        public void RemoveTail() //Remove Tail [d,b,a,c] -> [d,b,a]
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);
            DLLNode d = new DLLNode(4);
            DLList list = new DLList();
            list.addToTail(a);
            list.addToHead(b);
            list.addToTail(c);
            list.addToHead(d);
            list.removeTail();
            Assert.AreEqual(list.tail, a);
            Assert.AreEqual(list.tail.previous, b);
            Assert.AreEqual(list.tail.previous.previous, d);
        }

        [TestMethod]
        public void RemoveTailTwo() //Remove 2 Tail [d,b,a,c] -> [d,b]
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);
            DLLNode d = new DLLNode(4);
            DLList list = new DLList();
            list.addToTail(a);
            list.addToHead(b);
            list.addToTail(c);
            list.addToHead(d);
            list.removeTail();
            list.removeTail();
            Assert.AreEqual(list.tail, b);
            Assert.AreEqual(list.tail.previous, d);
        }


        [TestMethod]
        public void SearchTest() //search for a in [d,b,a,c]
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);
            DLLNode d = new DLLNode(4);
            DLList list = new DLList();
            list.addToTail(a);
            list.addToHead(b);
            list.addToTail(c);
            list.addToHead(d); 
            list.search(a.num);
            Assert.AreEqual(list.search(a.num), a);
        }

        [TestMethod]
        public void SearchTestNull() //search for x in [d,b,a,c] returns null
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);
            DLLNode d = new DLLNode(4);
            DLList list = new DLList();
            list.addToTail(a);
            list.addToHead(b);
            list.addToTail(c);
            list.addToHead(d);
            Assert.IsNull(list.search(33));
        }

        [TestMethod]
        public void SearchTestFirst() //search for d(first) in [d,b,a,c]
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);
            DLLNode d = new DLLNode(4);
            DLList list = new DLList();
            list.addToTail(a);
            list.addToHead(b);
            list.addToTail(c);
            list.addToHead(d);
            Assert.AreEqual(list.search(4), d);
        }

        [TestMethod]
        public void SearchTestLast() //search for c (last) in [d,b,a,c] 
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);
            DLLNode d = new DLLNode(4);
            DLList list = new DLList();
            list.addToTail(a);
            list.addToHead(b);
            list.addToTail(c);
            list.addToHead(d);
            Assert.AreEqual(list.search(3), c);
        }

        [TestMethod]
        public void RemoveNodeTest() //remove node b from [d,b,a,c] 
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);
            DLLNode d = new DLLNode(4);
            DLList list = new DLList();
            list.addToTail(a);
            list.addToHead(b);
            list.addToTail(c);
            list.addToHead(d);
            list.removeNode(b);
            Assert.AreEqual(list.head.next, a);
        }

        [TestMethod]
        public void RemoveNodeTailTest() //remove node c (end) from [d,b,a,c] 
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);
            DLLNode d = new DLLNode(4);
            DLList list = new DLList();
            list.addToTail(a);
            list.addToHead(b);
            list.addToTail(c);
            list.addToHead(d);
            list.removeNode(c);
            Assert.AreEqual(list.tail, a);
        }

        [TestMethod]
        public void RemoveNodeHeadTest() //remove node d (first) from [d,b,a,c] 
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);
            DLLNode d = new DLLNode(4);
            DLList list = new DLList();
            list.addToTail(a);
            list.addToHead(b);
            list.addToTail(c);
            list.addToHead(d);
            list.removeNode(d);
            Assert.AreEqual(list.head, b);
        }

        [TestMethod]
        public void TotalTest() //count nodes from [d,b,a,c] = 4
        {
            DLLNode a = new DLLNode(1);
            DLLNode b = new DLLNode(2);
            DLLNode c = new DLLNode(3);
            DLLNode d = new DLLNode(4);
            DLList list = new DLList();
            list.addToTail(a);
            list.addToHead(b);
            list.addToTail(c);
            list.addToHead(d);
            Assert.AreEqual(list.total(), 4);
        }

        [TestMethod]
        public void TotalZeroTest() //count nodes from [] = 0
        {
            DLList list = new DLList();
            Assert.AreEqual(list.total(), 0);
        }

        //End of Test
    }
}