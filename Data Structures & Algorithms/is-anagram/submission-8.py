class Solution:
    def isAnagram(self, str1, str2):
        if len(str1) != len(str2):
            return False

        hash = [0] * 26

        for i in range(len(str1)):
            hash[ord(str1[i]) - ord('a')] += 1 
            hash[ord(str2[i]) - ord('a')] -= 1 


        for item in hash:
            if item != 0:
                return False

        return True