class Solution:
    def topKFrequent(self, nums, k):
        count = defaultdict(int)
        freq = [[] for n in range(len(nums)+1)]

        for n in nums:
            count[n] += 1
        for c in count:
            freq[count[c]].append(c)

        top_k = []
        for f in range(len(freq)-1, 0, -1):
            for n in freq[f]:
                top_k.append(n)
                if len(top_k) == k:
                    return top_k
            
        return top_k