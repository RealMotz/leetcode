namespace code.Easy
{
    public class Problems1_100
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var memo = new Dictionary<int, int>();
            var knownElements = new HashSet<int>();
            var result = new int[2];
            for(int i=0; i<nums.Length; i++) {
                if(memo.TryGetValue(nums[i], out int value)) {
                    result[0] = value;
                    result[1] = i;
                    break;
                }

                var current = nums[i];
                if(knownElements.Contains(current)) {
                    continue;
                }

                knownElements.Add(current);
                int complement = target - current;
                if(current + complement == target) {
                    memo.Add(complement, i);
                } else {
                    memo.Add(target + current, i);
                }
            }

            return result;
        }
    }
}