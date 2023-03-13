namespace code.Algorithms
{
    public class TwoPointers
    {
        // Excecise # 1
        public int[] SortedSquares(int[] nums)
        {
            // Better solutions
            // return nums.Select(num => num * num).OrderBy(x => x).ToArray();

            // Even better solution
            // for (int i = 0; i < nums.Length; i++) {
            //     nums[i] = nums[i] * nums[i];
            // }
            // Array.Sort(nums);
            // return nums;

            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int item = nums[i];
                Insert(result, (item * item));
            }
            return result.ToArray();
        }

        public void Insert(List<int> nums, int target)
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] >= target)
                {
                    nums.Insert(i, target);
                    return;
                }
            }

            nums.Add(target);
        }

        // Excecise # 2
        public void Rotate(int[] nums, int k)
        {
            // Better solution
            // k = k % nums.Length;
            // Array.Reverse(nums, 0, nums.Length);
            // Array.Reverse(nums, 0, k);
            // Array.Reverse(nums, k, nums.Length - k);

            if (nums.Length - k == 0) return;
            else if (nums.Length - k < 0)
            {
                Reverse(nums, k % nums.Length);
            }
            else
            {
                Reverse(nums, k);
            }
        }

        private void Reverse(int[] nums, int k)
        {
            int[] leftArray = new int[nums.Length - k];
            int[] rightArray = new int[k];

            Array.Copy(nums, 0, leftArray, 0, nums.Length - k);
            Array.Copy(nums, nums.Length - k, rightArray, 0, k);

            Array.Copy(rightArray, 0, nums, 0, rightArray.Length);
            Array.Copy(leftArray, 0, nums, rightArray.Length, leftArray.Length);
        }

        // Excercise # 3
        // 13 min
        public void MoveZeroes(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0) continue;

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == 0) continue;

                    nums[i] = nums[j];
                    nums[j] = 0;
                    break;
                }
            }
        }

        // Excercise # 4
        public int[] TwoSum(int[] numbers, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < numbers.Length-1; i++) {
                for (int j = i+1; j < numbers.Length; j++) {
                    if(numbers[i] + numbers[j] == target) {
                        result[0] = i + 1;
                        result[1] = j + 1;
                        return result;
                    }
                }
            }
            return result;
        }
    }
}