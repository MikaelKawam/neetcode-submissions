class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        l, r = 0, 0
        hash = set()
        longest = 0

        while r < len(s):
            c = s[r]
            
            if c in hash:
                hash.remove(s[l])
                l += 1
            else:
                hash.add(c)
                r += 1 

            longest = max(r - l, longest)

        return longest
