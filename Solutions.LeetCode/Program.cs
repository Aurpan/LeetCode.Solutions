using Solutions.LeetCode.ArrayProblems;
using Solutions.LeetCode.StringProblems;

namespace Solutions.LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 217. Contains Duplicate

            //var obj217 = new LeetCode_217();
            //int[] numsArray = { 1, 2, 3, 1};

            //Console.WriteLine(obj217.ContainsDuplicate(numsArray));
            //Console.WriteLine(obj217.ContainsDuplicate_Better(numsArray));

            #endregion


            #region 242. Valid Anagram

            //var obj242 = new StringProblems.LeetCode_242();
            //var obj242_arr = new ArrayProblems.LeetCode_242();

            //Console.WriteLine(obj242.IsAnagram("car", "cat"));

            #endregion


            #region 1. Two Sum

            //var obj01 = new ArrayProblems.LeetCode_01();

            //int[] nums = { 2, 5, 5, 11 };
            ////var result = obj01.TwoSum(nums, 10);
            //var result = obj01.TwoSum_Better(nums, 10);

            //foreach (int num in result) 
            //{
            //    Console.WriteLine(num);
            //}

            #endregion


            #region 49. Group Anagrams

            //var obj49 = new LeetCode_49();

            //var x = obj49.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]);

            #endregion


            #region 347. Top K Frequent Elements

            //var obj347 = new LeetCode_347();

            //var x = obj347.TopKFrequent([1, 1, 1, 2, 2, 3], 3);

            #endregion


            #region 238. Product of Array Except Self

            //var obj238 = new LeetCode_238();

            //var x = obj238.ProductExceptSelf([4, 3]);

            #endregion


            #region 128. Longest Consecutive Sequence

            var obj128 = new LeetCode_128();

            var x = obj128.LongestConsecutive([100, 4, 200, 1, 3, 2]);

            #endregion

        }
    }
}
