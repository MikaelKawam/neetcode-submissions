class Solution:
    def findMin(self, nums: List[int]) -> int:
        l, r = 0, len(nums)-1
        count_rotated = 0
        while(l < r):
            isRotated = nums[l] > nums[r] 
            if isRotated:
                count_rotated += 1
                l += 1 
            else:
                break


        return nums[count_rotated]