namespace code.Algorithms
{
    using System.Collections.Generic;

    public class DynamicProgramming
    {
        public List<int>? HowSum(int target, List<int> numbers, Dictionary<int, List<int>?> memo) {
            if(memo.TryGetValue(target, out List<int>? value)) return value;
            if(target == 0) return new List<int>();
            if(target < 0) return null;

            foreach(var num in numbers) {
                int remainder = target - num;
                var result = HowSum(remainder, numbers, memo);
                if(result != null) {
                    result.Add(num);
                    memo[num] = result;
                    return memo[num];
                }
            }

            memo[target] = null;
            return null;
        }
    }
}