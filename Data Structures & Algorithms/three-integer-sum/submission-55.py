class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        length = len(nums)
        nums = sorted(nums)

        res = []
        for i in range(length-2):
            l, r = i+1, length-1
            while l < r:
                curr_sum = nums[i] + nums[l] + nums[r]
                if (curr_sum) == 0:
                    triplet = tuple(sorted([nums[i], nums[l], nums[r]]))
                    if triplet not in res:
                        res.append(triplet)
                    r -= 1
                    l += 1
                    continue   

                if curr_sum > 0:
                    r -= 1
                else:
                    l += 1

        return res