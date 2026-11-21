class Solution:
    def maxArea(self, heights: List[int]) -> int:
        length = len(heights)
        l, r = 0, length-1

        res = 0
        while l < r:
            cur = min(heights[l], heights[r])
            res = max(cur*(r-l), res)

            if heights[l] < heights[r]:
                l += 1
            else:
                r -= 1

        return res

        