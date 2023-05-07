namespace code.Algorithms
{
    public class BinarySearch
    {
        public bool IsBadVersion(int n) {
            if(n == 4) { return true; }
            if(n == 1702766719) { return true; }
            if(n == 55) { return true; }
            if(n == 8) { return true; }
            if(n == 99) { return true; }
            if(n == 34) { return true; }
            return false;
        }

        // Excercise 2
        public int FirstBadVersion(int n) {
            int start = 1;
            int end = n;
            int version = 0;

            while(start < end) {
                version = start + (end - start) / 2;
                if(IsBadVersion(version)) {
                    end = version;
                } else {
                    start = version + 1;
                    Console.WriteLine(start + " " + version);
                }
            }

            return start;
        }

        // Excercise 3
        public int SearchInsert(int[] nums, int target) {
            int start = 0;
            int end = nums.Length - 1;
            while(start <= end) {
                int middle = start + (end - start) / 2;
                if(nums[middle] == target) return middle;
                else if(nums[middle] > target) {
                    end = middle - 1;
                } else {
                    start = middle + 1;
                }
            }

            return start;
        }
    }
}