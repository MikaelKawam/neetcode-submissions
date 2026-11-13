class Solution:
    def groupAnagrams(self, strs):

        grouped = {}
        for s in strs:

            count = [0] * 26
            for c in s:
                count[ord(c) - ord('a')] += 1

            key = tuple(count)
            grouped.setdefault(key, []).append(s)

    
        return list(grouped.values())