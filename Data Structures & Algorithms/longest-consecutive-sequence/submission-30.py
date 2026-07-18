class Solution:
    def longestConsecutive(self, nums) -> int:
        nums_set = set(nums)
        max_streak = 0
        for i in range(len(nums)):
            curr = nums[i]
            curr_streak = 0
            while curr in nums_set:
                curr_streak += 1
                curr += 1

                max_streak = max(max_streak, curr_streak)

            
        return max_streak