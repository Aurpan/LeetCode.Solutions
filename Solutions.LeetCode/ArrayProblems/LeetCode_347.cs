namespace Solutions.LeetCode.ArrayProblems
{
    // 347. Top K Frequent Elements
    public class LeetCode_347
    {
        // T.C. => O(n) + O(n logn)
        // S.C. => O(n)
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> numsDict = new Dictionary<int, int>(); // S.C. => O(n)

            foreach (int num in nums) // T.C. => O(n)
            {
                if (numsDict.ContainsKey(num))
                    numsDict[num]++;
                else
                    numsDict.Add(num, 1);
            }

            return numsDict.OrderByDescending(_ => _.Value) // T.C. => O(n logn)
                .Take(k).Select(x => x.Key)
                .ToArray();

        }


    }
}
