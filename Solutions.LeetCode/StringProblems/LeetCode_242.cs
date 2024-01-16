namespace Solutions.LeetCode.StringProblems
{
    // 242. Valid Anagram
    public class LeetCode_242
    {
        // T.C. => 2 * O(n logn) + 2 * O(n) => O(n logn)
        // S.C. => 2 * O(n) => O(n)
        public bool IsAnagram(string s, string t)
        {
            char[] arrS = s.ToCharArray(); // S.C. => O(n)
            char[] arrT = t.ToCharArray(); // S.C. => O(n)

            Array.Sort(arrS); // T.C. => O(n logn)
            Array.Sort(arrT); // T.C. => O(n logn)

            return arrS.SequenceEqual(arrT); // T.C. => O(n)

        }
    }
}
