class Solution:
    def longestConsecutive(self, nums: List[int]) -> int:
        d = defaultdict(int)
        res = 0

        for n in nums:
            if not d[n]:
                # Update current
                d[n] = d[n-1] + d[n+1] + 1

                #Update left neighborhood with the new length
                d[n-d[n-1]] = d[n]

                #Update right neighborhood with the new length
                d[n+d[n+1]] = d[n]
                
                res = max(d[n], res)

        return res