namespace Solutions.LeetCode.ArrayProblems
{
    // 49. Group Anagrams
    public class LeetCode_49
    {
        // T.C. => O(m * n logn)
        // S.C. => O(n^2)
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string, List<string>> dictAnagrams = new Dictionary<string, List<string>>(); // S.C. => O(n)

            foreach (string str in strs)
            {
                char[] charArr = str.ToCharArray();
                Array.Sort(charArr); // T.C. => O(n logn)
                string sortedStr = new string(charArr);


                if (!dictAnagrams.ContainsKey(sortedStr))
                {
                    dictAnagrams.Add(sortedStr, new List<string>()); 
                }
               
                dictAnagrams[sortedStr].Add(str);
            }


            return dictAnagrams.Select(_ => _.Value).ToList<IList<string>>();
        }

    }
}
