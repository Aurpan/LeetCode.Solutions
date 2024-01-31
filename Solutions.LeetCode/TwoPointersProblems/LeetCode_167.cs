using System.Net;

namespace Solutions.LeetCode.TwoPointersProblems
{
    // 167. Two Sum II - Input Array Is Sorted
    public class LeetCode_167
    {
        // T.C. => O(n)
        // S.C. => O(1)
        public int[] TwoSum(int[] numbers, int target)
        {
            if (numbers.Length == 2)
                return [1, 2];

            int firstPointer = 0, lastPointer = numbers.Length - 1;


            for (int i = 0; i < numbers.Length; i++) // T.C. => O(n)
            {
                if (numbers[firstPointer] + numbers[lastPointer] > target)
                    lastPointer--;

                else if (numbers[firstPointer] + numbers[lastPointer] < target)
                    firstPointer++;

                else
                    break;
            }

            return [firstPointer + 1, lastPointer + 1];
        }
    }
}
