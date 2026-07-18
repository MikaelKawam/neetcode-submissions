class Solution:
    def longestConsecutive(self, nums) -> int:
        max_consecutive_sequence = 0
        nums_length = len(nums)
        for current_num in nums:
            i = 0
            hash_set = set()
            while i < nums_length:
                next_num = nums[i]
                if next_num - current_num == 1 and not next_num in hash_set:
                    hash_set.add(current_num)
                    current_num = next_num
                    i = 0
                else:
                    i += 1

            max_consecutive_sequence = max(len(hash_set) + 1,max_consecutive_sequence)

        return max_consecutive_sequence