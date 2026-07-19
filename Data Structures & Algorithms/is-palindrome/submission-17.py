class Solution:
    def isPalindrome(self, s: str) -> bool:
        l, r = 0, len(s) - 1
        s = s.lower()
        while l < r:
            if not (s[l].isalpha() or s[l].isdigit()):
                l += 1
                continue
                
            if not (s[r].isalpha() or s[r].isdigit()):
                r -= 1
                continue

            if s[r] != s[l]:
                return False
            r -= 1
            l += 1
            
        return True