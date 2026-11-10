class Solution:
    def twoSum(self, nums, target) :
        
        desiredValues = dict()

        for i, n in enumerate(nums):
            currTarget = target - n
            if currTarget in desiredValues:
                return [desiredValues[currTarget], i]

            desiredValues[n] = i
            

        return []
