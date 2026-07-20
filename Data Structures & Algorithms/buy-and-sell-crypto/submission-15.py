class Solution:
    def maxProfit(self, prices: List[int]) -> int:
        l, r  = 0, 1
        maxProfit = 0
        length = len(prices)
        while r < length:
            maxProfit = max(prices[r] - prices[l], maxProfit)

            if prices[l] > prices[r]:
                l = r
                r += 1
            else:
                r += 1

        return maxProfit