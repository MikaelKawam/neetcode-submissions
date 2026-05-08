public class Solution {
public int Search(int[] nums, int target)
{
    var l = 0;
    var r = nums.Length - 1;
    var mid = r/2;
    while (l <= r)
    {
        if (target == nums[mid])
            return mid;
        else if (target > nums[mid])
            l = mid + 1;
        else 
            r = mid - 1;

        mid = (r + l) / 2;
    };

    return -1;
}
}
