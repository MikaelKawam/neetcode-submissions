class Solution:
    def groupAnagrams(self, strs):

        grouped = {}
        for s in strs:

            count = [0] * 26
            for c in s:
                count[ord(c) - ord('a')] += 1

            key = tuple(count)
            if key not in grouped:
                grouped[key] = [s]
            else:
                grouped[key].append(s)


    
        return list(grouped.values())