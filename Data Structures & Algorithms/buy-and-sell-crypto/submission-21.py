class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        l, r = 0, 1

        profit = 0 
        while r <= len(prices)-1:
            if prices[l] < prices[r]:
                profit = max(prices[r]-prices[l], profit)
                r += 1
            else:
                l = r
                r += 1

        return profit