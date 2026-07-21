class Solution:
    def lengthOfLongestSubstring(self, s: str) -> int:
        l, r = 0, 0
        hash = set()
        longest = 0

        while r < len(s):
            c = s[r]
            
            if c not in hash:
                hash.add(c)
                r += 1
            else:
                l += 1
                r = l

                hash = set()
                continue

            longest = max(r - l, longest)

        return longest
