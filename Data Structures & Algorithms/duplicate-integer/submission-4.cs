public class Solution {
    public bool hasDuplicate(int[] nums) {
        var numCount = nums.Count();
        if(numCount == 0)
        {
            return false;
        }
        var numsIdxEnd = nums.Count() - 1;
        var j = 0;
        var i = 0;
        while(j != numsIdxEnd)
        {
            i++;
            if(nums[j] == nums[i])
            {
                return true;
            }
            if(i == numsIdxEnd)
            {
                j++;
                i = j;
            }
        }
        return false;
    }
}