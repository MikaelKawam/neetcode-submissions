class Solution:
    def isValid(self, s: str):
        closeBrackets = { 
            ')': '(',
            ']': '[',
            '}': '{',
        }

        arr = []
        for c in s:
            if c not in closeBrackets:
                arr.append(c)
            elif arr and arr[-1] == closeBrackets[c]:
                arr.pop()
            else:
                return False
            

        return len(arr) == 0;


        