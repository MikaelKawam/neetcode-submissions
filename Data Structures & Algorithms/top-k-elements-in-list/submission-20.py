class Solution:
    def topKFrequent(self, nums, k):
        count = defaultdict(int)
        top_k = []
        freq = [[] for n in range(len(nums)+1)]

        for n in nums:
            count[n] += 1

        for c in count:
            freq[count[c]].append(c)

        for f in range(len(freq)-1, 0, -1):
            for i in range(len(freq[f])):
                if k > 0 and freq[f][i] != None:
                    top_k.append(freq[f][i])
                    k -= 1
                elif k == 0:
                    break
            
        return top_k