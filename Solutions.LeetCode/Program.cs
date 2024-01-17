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

            var obj01 = new ArrayProblems.LeetCode_01();

            int[] nums = { 2, 5, 5, 11 };
            //var result = obj01.TwoSum(nums, 10);
            var result = obj01.TwoSum_Better(nums, 10);
            
            foreach (int num in result) 
            {
                Console.WriteLine(num);
            }

            #endregion



        }
    }
}
