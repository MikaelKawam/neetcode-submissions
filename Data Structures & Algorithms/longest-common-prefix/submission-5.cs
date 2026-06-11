public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        var prefix = strs[0];

        for (var i = 1; i < strs.Length; i++)
        {
            var j = 0;
            while  (j < Math.Min(prefix.Length, strs[i].Length))
            {
                if (prefix[j] != strs[i][j])
                {
                    break;
                }
                j++;
            }
            prefix = prefix.Substring(0, j);
        }

        return prefix;
    }
}