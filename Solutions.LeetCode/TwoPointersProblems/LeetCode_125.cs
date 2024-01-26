namespace Solutions.LeetCode.TwoPointersProblems
{
    // 125. Valid Palindrome
    public class LeetCode_125
    {
        // T.C. => O(n)
        // S.C. => O(n)
        public bool IsPalindrome(string s)
        {
            List<char> chars = new List<char>(); // S.C. => O(n)

            foreach (char c in s) // T.C. => O(n)
            {
                if (Char.IsLetter(c) || Char.IsDigit(c))
                    chars.Add(Char.ToLower(c));
            }

            int i = 0, j = chars.Count - 1;

            while (i < j)
            {
                if (chars[i] != chars[j])
                    return false;

                i++;
                j--;
            }

            return true;
        }
    }
}
