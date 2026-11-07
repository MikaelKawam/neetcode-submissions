class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        hash = set()

        for n in nums:
            if n not in hash:
                hash.add(n)
            else:
                return True


        return False