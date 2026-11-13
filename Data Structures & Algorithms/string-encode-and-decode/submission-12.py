class Solution:

    def encode(self, strs: List[str]) -> str:

        encoded_str = []
        for s in strs:
            encoded_str.append(str(len(s))+ "#" + s)

        return "".join(encoded_str)

    def decode(self, s: str) -> List[str]:

        i = 0
        list_len = []
        while i < len(s):
            len_str = ""
            while s[i] != '#':
                len_str += s[i]
                i += 1

            i += 1
            int_len = int(len_str) 
            start = i
            end =   int(len_str) + i
            list_len.append(tuple([start,end]))
            i += int_len

            
        str_list=[]
        i = 0
        for idxs in list_len:
            str_list.append(s[idxs[0]:idxs[1]])


        return str_list