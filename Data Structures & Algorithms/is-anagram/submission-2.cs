public class Solution {
    public bool IsAnagram(string s, string t)
    {
        // Valid if the strings are the same length.
        var sLength = s.Length;
        var tLength = t.Length;
        if(sLength != tLength) return false;

        // Init Dict to see if each char is present in the same quantity in both strings.
        var dictKeysCount = new Dictionary<char, int>();

        foreach(var c in s)
        {
            if(dictKeysCount.ContainsKey(c))
                dictKeysCount[c]++;
            else
                dictKeysCount[c] = 1;
        }

        foreach (var c in t)
            if (dictKeysCount.ContainsKey(c))
            {
                if (dictKeysCount[c] > 1) dictKeysCount[c]--;
                else dictKeysCount.Remove(c);
            }

        if (dictKeysCount.Count() == 0) return true;


        return false;
    }
}
