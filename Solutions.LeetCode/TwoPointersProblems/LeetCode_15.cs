namespace Solutions.LeetCode.TwoPointersProblems
{
    // 15. 3Sum
    public class LeetCode_15
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            Array.Sort(nums);
            var result = new List<IList<int>>();
            HashSet<string> uniqueCombinations = new HashSet<string>();
            //bool isFound = false;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    break;

                int start = 0, end = nums.Length - 1, target = 0 - nums[i];

                //for (int j = 0; j < nums.Length && start != end; j++) // T.C. => O(n)
                while(start < nums.Length && end >= 0 && start != end)
                {
                    if (start == i)
                        start++;
                    if (end == i)
                        end--;

                    if (nums[start] + nums[end] > target)
                        end--;

                    else if (nums[start] + nums[end] < target)
                        start++;

                    else
                    {
                        //isFound = true;
                        //break;

                        List<int> triples = [nums[i], nums[start], nums[end]];

                        triples.Sort();

                        string triplesStr = String.Empty;
                        foreach (var triple in triples)
                        {
                            triplesStr += triple.ToString();
                        }

                        if (!uniqueCombinations.Contains(triplesStr))
                        {
                            uniqueCombinations.Add(triplesStr);

                            result.Add(triples);
                        }

                        start++;
                        end--;
                    }
                }

                //if (isFound)
                //{
                //    List<int> triples = [nums[i], nums[start], nums[end]];

                //    triples.Sort();

                //    string triplesStr = String.Empty;
                //    foreach (var triple in triples)
                //    {
                //        triplesStr += triple.ToString();
                //    }

                //    if (!uniqueCombinations.Contains(triplesStr))
                //    {
                //        uniqueCombinations.Add(triplesStr);

                //        result.Add(triples);
                //    }
                //}

            }

            return result;

        }

    }
}
