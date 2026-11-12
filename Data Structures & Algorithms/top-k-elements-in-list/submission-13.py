class Solution:
    def topKFrequent(self, nums, k):
        count = {}
        freq = [[] for i in range(len(nums)+1)]

        for n in nums:
            count[n] = count.get(n,0) + 1

        for i, c in enumerate(count):
            freq[count[c]].append(c)

        res = []
        for i in range(len(freq)-1, 0, -1):
            for f, n in enumerate(freq[i]):
                if(len(res) < k):
                    res.append(n)

        return res