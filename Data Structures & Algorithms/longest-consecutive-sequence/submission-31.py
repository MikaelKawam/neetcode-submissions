class Solution:
    def bubbleSort(self, nums, length):
        for i in range(length):
            swapped = False
            for j in range(0, length - 1 - i, 1):
                if nums[j] > nums[j + 1]:
                    nums[j], nums[j+1] = nums[j+1], nums[j]
                    swapped = True
            if not swapped:
                break
        return nums

    def longestConsecutive(self, nums) -> int:
        l = len(nums) 
        if l == 0 : return 0

        nums = self.bubbleSort(nums, l)
            
        res = 0
        curr = nums[0]
        streak = 0 
        i = 0
        while i < l:
            if nums[i] == curr:
                i += 1
            elif curr + 1 == nums[i]:
                streak += 1
                curr += 1
                res = max(streak, res)
            else:
                curr = nums[i]
                streak = 0

        return res + 1