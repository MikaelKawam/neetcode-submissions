class Solution:
    def findMin(self, nums: List[int]) -> int:
        l, r = 0, len(nums)-1
        m = ((r - l) // 2) + l
        res = nums[0]

        while (l <= r):
            if nums[m] >= nums[r]:
                res = min(nums[m], res)
                l = m + 1
            else:
                res = min(nums[m], res)
                r = m - 1

            
            m = ((r - l) // 2) + l

        return res