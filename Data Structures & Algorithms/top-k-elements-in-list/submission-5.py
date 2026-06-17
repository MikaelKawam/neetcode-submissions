import heapq

class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        d = {}
        for n in nums: 
            if n not in d:
                d[n] = 0
            d[n] += 1
            
        top_k = list(sorted(d, key=lambda x: d[x], reverse=True))[0:k]
        return top_k
