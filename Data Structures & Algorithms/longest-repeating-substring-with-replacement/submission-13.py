class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        res = 0
        length = len(s)
        for l in range(length):
            freq_map = {}
            maxFreq = 0
            r = l 
            while (r < length):
                freq_map[s[r]] = freq_map.get(s[r],0) + 1
                maxFreq = max(freq_map[s[r]],  maxFreq)
                windowSize = (r - l) + 1
                replacements = windowSize - maxFreq
                if replacements <= k:
                    res = max(windowSize, res)
                r+= 1


        return res