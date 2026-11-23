class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        h = set()
        maxLength = 0
        l = 0
        for r in range(len(s)):
            while s[r] in h:
                h.remove(s[l])
                l += 1

            h.add(s[r])
            maxLength = max(r - l + 1, maxLength)

        return maxLength