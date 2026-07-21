class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
        res = 0
        length = len(s)
        for l in range(length):
            map_freq = {}
            max_freq = 0

            r = l

            while r < length:
                map_freq[s[r]] = map_freq.get(s[r], 0) + 1
                max_freq = max(max_freq, map_freq[s[r]])

                window_size = (r-l) + 1
                replacements = window_size - max_freq
                if replacements <= k:
                    res = max(res, window_size)
                
                r+= 1

        return res 