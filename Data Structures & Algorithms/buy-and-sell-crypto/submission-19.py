class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        l, r  = 0, 1
        maxProfit = 0
        length = len(prices)
        while r < length:

            if prices[l] < prices[r]:
                maxProfit = max(prices[r] - prices[l], maxProfit)
            else:
                l = r

            r += 1

        return maxProfit