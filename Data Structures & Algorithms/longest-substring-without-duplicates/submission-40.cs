public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        int l = 0, r = 0;
        int maxLength = 0;
        var hashSet = new HashSet<int>();

        var len = s.Length - 1;
        while (r < s.Length) {
            if (hashSet.Contains(s[r])) {
                hashSet.Remove(s[l]);
                l++;
            } else {
                hashSet.Add(s[r]);
                maxLength = Math.Max(maxLength, r - l + 1);
                r++;
            }
        };

        return maxLength;
    }
}
