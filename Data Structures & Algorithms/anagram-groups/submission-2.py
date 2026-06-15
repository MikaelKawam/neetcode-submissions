class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        # key: 26-length tuple (char freq)
        hash = {}
        #value: list of strings belonging to that anagram group

        for s in strs:
            count = [0] * 26
            for c in s:
                count[ord(c) - ord('a')] += 1

            #convert the count array to a tuple and use it as the key.
            t = tuple(count)
            if t not in hash:
                hash[t] = []

            hash[t].append(s)

        return list(hash.values())
        