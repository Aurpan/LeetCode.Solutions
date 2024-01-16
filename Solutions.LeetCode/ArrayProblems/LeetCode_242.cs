namespace Solutions.LeetCode.ArrayProblems
{
    // 242. Valid Anagram
    public class LeetCode_242
    {
        // T.C. => O(n) + O(n) => O(n)
        // S.C. => 
        public bool IsAnagram(string s, string t)
        {
            Dictionary<char, int> sDict = new Dictionary<char, int>();
            Dictionary<char, int> tDict = new Dictionary<char, int>();

            if (s.Length != t.Length)
                return false;


            for (int i = 0; i < s.Length; i++) // T.C. => O(n)
            {
                if (sDict.ContainsKey(s[i])) 
                    sDict[s[i]]++;
                else
                    sDict.Add(s[i], 1);

                
                if (tDict.ContainsKey(t[i]))
                    tDict[t[i]]++;
                else
                    tDict.Add(t[i], 1);
            }

            for (int i = 0; i < s.Length; i++) // T.C. => O(n)
            {
                if (!tDict.TryGetValue(s[i], out int val) || sDict[s[i]] != val)
                    return false;
            }

            return true;


        }
    }
}
