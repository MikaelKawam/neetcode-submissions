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
            j = count
            while s[j] != self.SEP:
                j += 1

            length = int(s[count:j])

            count = j + 1
            j = count + length

            res.append(s[count:j])
            count = j

        return res