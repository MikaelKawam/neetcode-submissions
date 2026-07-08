
class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        d = {}
        for num in nums:
            d[num] = 1 + d.get(num, 0)

        items = list(d.items())
        n = len(items)
        for i in range(n):
            for j in range(n - 1 - i):
                if items[j][1] < items[j + 1][1]:
                    items[j], items[j + 1] = items[j + 1], items[j]

        return list(dict(items).keys())[:k]
