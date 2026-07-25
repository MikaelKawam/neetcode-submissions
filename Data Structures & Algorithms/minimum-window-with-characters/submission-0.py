class Solution:
    def minWindow(self, s: str, t: str) -> str:
        len_s = len(s)
        if len_s < len(t): return ""

        need = {}
        for c in t: need[c] = 1 + need.get(c, 0)

        have = {}
        have_count = 0
        l = 0
        res = ""
        for r in range(len_s):
            if s[r] in need:
                have[s[r]] = have.get(s[r], 0) + 1
                if have[s[r]] == need[s[r]]:
                    have_count += 1

            while have_count == len(need):
                if res == "" or r - l + 1 < len(res):
                    res = s[l:r+1]
                if s[l] in need:
                    have[s[l]] -= 1
                    if have[s[l]] < need[s[l]]:
                        have_count -= 1
                l += 1
        
        return res 
