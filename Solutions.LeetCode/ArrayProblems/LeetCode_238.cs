namespace Solutions.LeetCode.ArrayProblems
{
    public class LeetCode_238
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            // T.C. => 3 * O(n) => O(n)
            // S.C. => 3 * O(n) => O(n)

            int arrLength = nums.Length;
            int[] arrPrefProduct = new int[arrLength]; // S.C. => O(n)
            int[] arrPostProduct = new int[arrLength]; // S.C. => O(n)
            int[] result = new int[arrLength]; // S.C. => O(n)

            arrPrefProduct[0] = 1;
            arrPostProduct[arrLength - 1] = 1;

            for (int i = 1; i < arrLength; i++) // T.C. => O(n) + O(n)
            {
                arrPrefProduct[i] = arrPrefProduct[i - 1] * nums[i - 1];

                arrPostProduct[arrLength - (i + 1)] = arrPostProduct[arrLength - i] * nums[arrLength - i];
            }

            for (int i = 0; i < arrLength; i++) // T.C. => O(n)
            {
                result[i] = arrPrefProduct[i] * arrPostProduct[i];
            }

            return result;
        }
    }
}
