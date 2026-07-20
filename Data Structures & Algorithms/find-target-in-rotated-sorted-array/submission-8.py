class Solution:
    def search(self, nums: List[int], target: int) -> int:
        l, r = 0, len(nums)-1

        while(l < r):
            m = l + ((r-l)//2)

            if nums[m] > nums[r]:
                l = m +1
            else:
                r = m

        pivot = l

        if pivot == 0:
            l, r = 0, len(nums) - 1
        elif nums[pivot] <= target <= nums[-1]:
            l, r = pivot, len(nums) - 1
        else:
            l, r = 0, pivot - 1

        while(l <= r):
            m = l + ((r-l)//2)

            if m == len(nums):
                break 

            if target == nums[m]:
                return m
            elif target > nums[m]:
                l = m+1
            else:
                r = m-1
        
        return -1