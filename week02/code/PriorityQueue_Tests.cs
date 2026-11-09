using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities.
    // Expected Result: Items should be removed from highest to lowest priority.
    // Defect(s) Found: The Dequeue method does not remove items from the queue.
    // It also does not check the last item when looking for the highest priority.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        Assert.AreEqual("Tim", priorityQueue.Dequeue());
        Assert.AreEqual("Sue", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add three items with the same priority.
    // Expected Result: Items should be removed in FIFO order.
    // Defect(s) Found: The queue does not follow FIFO when items have the same priority.
    // The Dequeue method also does not remove items from the queue.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 5);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 5);

        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Tim", priorityQueue.Dequeue());
        Assert.AreEqual("Sue", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add items with different and repeated priorities.
    // Expected Result: Higher priorities should be removed first,
    // and items with equal priorities should follow FIFO order.
    // Defect(s) Found: The queue selects the wrong item when priorities are equal.
    // It also skips the last item and does not remove items after returning them.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);
        priorityQueue.Enqueue("George", 5);
        priorityQueue.Enqueue("Anna", 1);

        Assert.AreEqual("Tim", priorityQueue.Dequeue());
        Assert.AreEqual("George", priorityQueue.Dequeue());
        Assert.AreEqual("Sue", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("Anna", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Try to remove an item from an empty queue.
    // Expected Result: An InvalidOperationException should be thrown
    // with the message "The queue is empty."
    // Defect(s) Found: No defects found. The correct exception and message are returned.
        public void TestPriorityQueue_4()
        {
            var priorityQueue = new PriorityQueue();

            try
            {
                priorityQueue.Dequeue();
                Assert.Fail("An exception should have been thrown.");
            }
            catch (InvalidOperationException e)
            {
                Assert.AreEqual("The queue is empty.", e.Message);
            }
            catch (AssertFailedException)
            {
                throw;
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected exception: " + e.Message);
            }
        }
}