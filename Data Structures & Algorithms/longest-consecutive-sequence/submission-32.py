class Solution:
    def longestConsecutive(self, nums) -> int:
        mp = {}
        res = 0
        
        for num in nums:
            if num in mp:
                continue
            
            left = mp.get(num-1, 0)
            right = mp.get(num+1, 0)
            length =  left + right + 1
            mp[num] = length

            if left > 0:
                mp[num -  mp.get(num-1, 0)] = length
            if right > 0:
                mp[num + mp.get(num+1, 0)] = length

            res = max(res, mp[num])
        
        return res