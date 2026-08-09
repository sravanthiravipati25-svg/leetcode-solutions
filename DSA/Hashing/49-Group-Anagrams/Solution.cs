// LeetCode 49 - Group Anagrams
// https://leetcode.com/problems/group-anagrams/
//
// Time Complexity: O(n * k log k)
// Space Complexity: O(n * k)

using System;
using System.Collections.Generic;

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach (string word in strs)
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            if (!map.ContainsKey(key))
                map[key] = new List<string>();

            map[key].Add(word);
        }

        IList<IList<string>> result = new List<IList<string>>();

        foreach (List<string> group in map.Values)
            result.Add(group);

        return result;
    }
}
