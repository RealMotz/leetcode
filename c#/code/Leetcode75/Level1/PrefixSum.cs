namespace code.Leetcode75.Level1
{
    public class PrefixSum
    {
        public static int[] RunningSum(int[] nums)
        {
            int[] result = new int[nums.Length];
            result[0] = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result[i] = result[i - 1] + nums[i];
            }

            return result;
        }

        public static int PivotIndex(int[] nums)
        {
            int left = 0;
            int right = nums.Sum();
            for (int i = 0; i < nums.Length; i++)
            {
                right -= nums[i];
                if (left == right)
                {
                    return i;
                }

                left += nums[i];
            }

            return -1;
        }
    }
}