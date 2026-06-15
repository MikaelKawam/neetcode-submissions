class Solution:
    def characterReplacement(self, s: str, k: int) -> int:
      
        left = 0
        best = 0

        count = {} #frequency of chars in current window
        most_frequent = 0

        for right in range(0, len(s)):
            
            count[s[right]] = count.get(s[right], 0) + 1 #expand window

            most_frequent = max(most_frequent, count[s[right]])

            window_size = right - left + 1

            replacements_needed = window_size - most_frequent

            while replacements_needed > k:

                # shrink window from left
                count[s[left]] -= 1
                left += 1

                window_size = right - left + 1
                
                replacements_needed = window_size - most_frequent
        
            best = max(best, window_size)

        return best