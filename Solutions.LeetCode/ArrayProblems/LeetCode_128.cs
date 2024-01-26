namespace Solutions.LeetCode.ArrayProblems
{
    // 128. Longest Consecutive Sequence
    public class LeetCode_128
    {
        // T.C. => O(n)
        // S.C. => O(n)
        public int LongestConsecutive(int[] nums)
        {
            if (nums.Length < 1) 
                return 0;

            HashSet<int> hashNums = new HashSet<int>(nums); // S.C. => O(n)
            int maxVal = 0;

            foreach (int num in nums) // T.C. => O(n) 
            {
                // this tasks will be executed for those who don't have any previous value
                // which is why no number will be traversed twice
                if (!hashNums.Contains(num - 1)) 
                {
                    int cnt = 1;
                    int currentNum = num;
                    while (hashNums.Contains(currentNum + 1))
                    {
                        currentNum++;
                        cnt++;
                    }

                    maxVal = Math.Max(cnt, maxVal);
                }
            }


            return maxVal;
        }
    }
}
