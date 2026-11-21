class Solution:
    def isPalindrome(self, s: str) -> bool:
        l, r = 0, len(s)-1

        def IsAlphaNum(c):
            valid_nums = ['0','1','2','3','4','5','6','7','8','9']
            valid_letters = ['a','b', 'c','d','e','f','g','h','i','j','k','l','m','o','p','q','r','s','t','u','v','w','x','y','z']

            if c not in valid_nums and c not in valid_letters:
                return False

            return True

        while l < r:
            while l < r and not IsAlphaNum(s[l].lower()):
                l += 1
            while  l < r and not IsAlphaNum(s[r].lower()):
                r -= 1  

            if s[l].lower() != s[r].lower():
                return False

            l += 1
            r -= 1

        return True