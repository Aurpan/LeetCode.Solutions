namespace Solutions.LeetCode.ArrayProblems
{
    // 1. Two Sum
    public class LeetCode_01
    {
        // Brute Force Solution
        // T.C. => O(n^2)
        public int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++) // T.C. => O(n)
            {
                for (int j = i + 1; j < nums.Length; j++) // T.C. => O(n)
                {
                    if (nums[i] + nums[j] == target)
                        return [i, j];
                }
            }

            return new int[2];
        }



        // Better Solution
        // T.C. => O(2 * n) => O(n)
        // S.C. => O(n)
        public int[] TwoSum_Better(int[] nums, int target)
        {
            if (nums.Length == 2)
                return [0, 1];

            Dictionary<int, int> numsDict = new Dictionary<int, int>(); // S.C. => O(n)

            for (int i = 0; i < nums.Length; i++) // T.C. => O(n)
            {
                if (numsDict.ContainsKey(target - nums[i])) // O(1)
                    return [numsDict[target - nums[i]], i];


                if (!numsDict.ContainsKey(nums[i])) // O(1)
                    numsDict.Add(nums[i], i);
            }

            return new int[2];
        }
    }
}
