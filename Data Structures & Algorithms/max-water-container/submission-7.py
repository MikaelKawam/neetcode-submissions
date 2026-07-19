class Solution:
    def maxArea(self, heights: List[int]) -> int:
        
        l, r = 0, len(heights)-1
        maxArea = 0
        while l < r:
            length = r-l
            uniform = min(heights[r], heights[l])
            curr_max = uniform * length
            maxArea = max(maxArea, curr_max)

            if heights[l] > heights[r]:
                r -= 1
            else: 
                l += 1


        return maxArea