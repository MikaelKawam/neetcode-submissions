public class Solution {
    public int Search(int[] nums, int target)
    {
        var r = 0;
        var l = nums.Count() - 1;
        var m = 0;

        while (r <= l)
        {
            m = (r + l) / 2;
            if (target == nums[m])
                break;
            else if (target > nums[m])
                r = m + 1;
            else
                l = m - 1;
        }
        if (nums[m] != target) return -1;
        
        return m;
    }
}
