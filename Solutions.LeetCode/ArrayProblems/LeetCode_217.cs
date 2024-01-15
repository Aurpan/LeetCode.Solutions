namespace Solutions.LeetCode.ArrayProblems
{
    // 217. Contains Duplicate
    public class LeetCode_217
    {
        // Brute Force Solution
        // T.C => O(n logn) + O(n)
        // S.C => O(n)
        public bool ContainsDuplicate(int[] nums)
        {
            Array.Sort(nums); // T.C => O(n logn)

            for (int i = 0; i < (nums.Length - 1); i++) // T.C => O(n)
            {
                if (nums[i] == nums[i + 1])
                    return true;
            }

            return false;
        }



        // Btter Solution
        // T.C => 2 * O(n) => O(n)
        // S.C => O(n)
        public bool ContainsDuplicate_Better(int[] nums)
        {
            Dictionary<int, bool> numsDict = new Dictionary<int, bool>(); // S.C => O(n)

            for (int i = 0; i < nums.Length; i++) // T.C => O(n)
            {
                if (numsDict.TryGetValue(nums[i], out bool val)) // T.C => O(1)
                    return true;

                numsDict.Add(nums[i], false); // T.C => O(1)
            }

            return false;
        }
    }
}
