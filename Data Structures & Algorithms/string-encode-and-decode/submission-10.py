class Solution:
    SEP = '#'

    def encode(self, strs: List[str]) -> str:
        res = ""
        for s in strs:
            res += str(len(s)) + self.SEP + s

        return res


    def decode(self, s: str) -> List[str]:
        last = 0
        res = []
        count = 0
        while count < len(s):
            if s[count] == self.SEP:
                num = int(s[last:count])
                count += 1
                res.append(s[count:count + num])
                count += num
                last = count
            else:
                count += 1

        return res