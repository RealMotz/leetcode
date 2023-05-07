namespace code.test
{
    using System.Collections.Generic;
    using code.Algorithms;

    public class DynamicProgrammingTest
    {
        [Test]
        public void HowSum_1() {
            // Arrange
            DynamicProgramming dp = new();
            int target = 7;
            List<int> nums = new() { 2, 3 };
            List<int>? expected = new() { 3, 2, 2 };

            // Act
            var result = dp.HowSum(target, nums, new Dictionary<int, List<int>?>());

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void HowSum_2() {
            // Arrange
            DynamicProgramming dp = new();
            int target = 7;
            List<int> nums = new() { 2, 4 };
            List<int>? expected = null;

            // Act
            var result = dp.HowSum(target, nums, new Dictionary<int, List<int>?>());

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

                [Test]
        public void HowSum_3() {
            // Arrange
            DynamicProgramming dp = new();
            int target = 300;
            List<int> nums = new() { 7, 14 };
            List<int>? expected = null;

            // Act
            var result = dp.HowSum(target, nums, new Dictionary<int, List<int>?>());

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}