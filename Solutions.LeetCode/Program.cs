using Solutions.LeetCode.ArrayProblems;

namespace Solutions.LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 217. Contains Duplicate

            var obj217 = new LeetCode_217();
            int[] numsArray = { 1, 2, 3, 1};

            Console.WriteLine(obj217.ContainsDuplicate(numsArray));
            Console.WriteLine(obj217.ContainsDuplicate_Better(numsArray));

            #endregion
        }
    }
}
