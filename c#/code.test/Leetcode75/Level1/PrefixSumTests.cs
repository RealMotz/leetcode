namespace code.test.Leetcode75.Level1
{
    using code.Leetcode75.Level1;

    public class PrefixSumTests
    {
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 1, 3, 6, 10 })]
        [TestCase(new int[] { 1, 1, 1, 1, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 3, 1, 2, 10, 1 }, new int[] { 3, 4, 6, 16, 17 })]
        public void RunningSum_GivenList_ReturnPrefixSum(int[] nums, int[] expectedResult)
        {
            // Act
            var result = PrefixSum.RunningSum(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(new int[] { 1, 7, 3, 6, 5, 6 }, 3)]
        [TestCase(new int[] { 1, 2, 3 }, -1)]
        [TestCase(new int[] { 2, 1, -1 }, 0)]
        public void PivotIndex_GivenList_ReturnPivotIndex(int[] nums, int expectedResult)
        {
            // Act
            var result = PrefixSum.PivotIndex(nums);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

    }
}