namespace code.test;
using code.Algorithms;

public class TwoPointersTest
{
    [Test]
    [TestCase(new int[] { -4,-1,0,3,10 }, new int[] { 0,1,9,16,100 })]
    [TestCase(new int[] { -7,-3,2,3,11}, new int[] { 4,9,9,49,121 })]
    public void SortedSquares_GivenAscOrderList_SquareEachNumber_ReturnAscOrderList(int[] nums, int[] expectedResult)
    {
        // Assign
        TwoPointers pointers = new TwoPointers();

        // Act
        var result = pointers.SortedSquares(nums);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(new int[] { 1,2,3,4,5,6,7 }, 3, new int[] { 5,6,7,1,2,3,4 })]
    [TestCase(new int[] { -1,-100,3,99 }, 2, new int[] { 3,99,-1,-100 })]
    [TestCase(new int[] { -1 }, 2, new int[] { -1 })]
    [TestCase(new int[] { -1,-2 }, 3, new int[] { -2, -1 })]
    public void Rotate(int[] nums, int k, int[] expectedResult)
    {
        // Assign
        TwoPointers pointers = new TwoPointers();

        // Act
        pointers.Rotate(nums, k);

        // Assert
        Assert.That(nums, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(new int[] { 0,1,0,3,12 }, new int[] { 1,3,12,0,0})]
    [TestCase(new int[] { 1,0,2,0,3 }, new int[] { 1,2,3,0,0 })]
    [TestCase(new int[] { 0 }, new int[] { 0 })]
    [TestCase(new int[] { 1,2,3,4,5,6,0,0 }, new int[] { 1,2,3,4,5,6,0,0  })]
    public void MoveZeroes(int[] nums, int[] expectedResult) {
       // Assign
        TwoPointers pointers = new TwoPointers();

        // Act
        pointers.MoveZeroes(nums);

        // Assert
        Assert.That(nums, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(new int[] { 2,7,11,15 }, 9, new int[2] { 1, 2 })]
    [TestCase(new int[] { 2,3,4 }, 6, new int[2] { 1, 3 })]
    [TestCase(new int[] { -1,0 }, -1, new int[2] { 1, 2 })]
    public void TwoSum(int[] nums, int target, int[] expectedResult) {
       // Assign
        TwoPointers pointers = new TwoPointers();

        // Act
        var result = pointers.TwoSum(nums, target);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}