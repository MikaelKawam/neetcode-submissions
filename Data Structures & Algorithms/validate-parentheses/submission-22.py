class Solution:
    def isValid(self, s: str) -> bool:
        valid_close = {"]":"[", ")":"(", "}":"{"}
        valid_open = {"[", "(", "{"}

        stack = []

        for c in s:
            if c in valid_open:
                stack.append(c)
            elif len(stack) > 0 and stack[-1] == valid_close[c]:
                stack.pop()
            else:
                return False
        
        return len(stack) == 0
