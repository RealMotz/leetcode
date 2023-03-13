namespace code.test;
using code.Algorithms;
using code.DataStructures;

public class RecursionTest
{
    public ListNode CreateLinkedList(int[] values) {
        ListNode head = new ListNode();
        if(values.Length > 0) {
            head.val = values[0];
        }

        ListNode tail = new ListNode();
        for (int i = 1; i < values.Length; i++) {
            ListNode newNode = new ListNode(values[i]);
            if(i == 1) {
                head.next = newNode;
            } else {
                tail.next = newNode;
            }
            tail = newNode;
        }

        return head;
    }

    [Test]
    [Ignore("Ignore a this")]
    [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 2, 1, 4, 3 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 1, 4, 3, 5 })]
    [TestCase(new int[] { 1 }, new int[] { 1 })]
    public void SwapPairs(int[] nums, int[] expectedResult) {
       // Assign
        Recursion recursion = new Recursion();
        ListNode head = CreateLinkedList(nums);

        // Act
        ListNode nodes = recursion.SwapPairs(head);

        // Assert
        Assert.That(nodes.GetNodeList(), Is.EqualTo(expectedResult));
    }

    [Test]
    [Ignore("Ignore a this")]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
    [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 4, 3, 2, 1 })]
    [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
    [TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
    [TestCase(new int[] { 1 }, new int[] { 1 })]
    public void ReverseList(int[] nodes, int[] expectedResult) {
       // Assign
        Recursion recursion = new Recursion();
        ListNode head = CreateLinkedList(nodes);

        // Act
        ListNode result = recursion.ReverseList(head);

        // Assert
        Assert.That(result.GetNodeList(), Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(4, new int[] { 1, 4, 6, 4, 1 })]
    [TestCase(3, new int[] { 1, 3, 3, 1 })]
    [TestCase(2, new int[] { 1, 2, 1 })]
    [TestCase(1, new int[] { 1, 1 })]
    [TestCase(0, new int[] { 1 })]
    public void PascalTriangleRow(int index, int[] expectedResult) {
       // Assign
        Recursion recursion = new Recursion();

        // Act
        IList<int> result = recursion.PascalTriangleRow(index);

        // Assert
        Assert.That(result.ToList(), Is.EqualTo(expectedResult));
    }
}
