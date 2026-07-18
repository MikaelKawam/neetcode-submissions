class Solution:
    def longestConsecutive(self, nums) -> int:
        max_consecutive_sequence = 0
        for current_num in nums:
            current_consecutive_sequence = 1
            i = 0
            hash_set = set()
            while i < len(nums):
                next_num = nums[i]
                is_next_consecutive = next_num - current_num == 1
                already_used = next_num in hash_set
                if is_next_consecutive and not already_used:
                    current_consecutive_sequence += 1
                    hash_set.add(current_num)
                    current_num = next_num
                    i = 0
                else:
                    i += 1

                max_consecutive_sequence = max(current_consecutive_sequence,max_consecutive_sequence)

        return max_consecutive_sequence