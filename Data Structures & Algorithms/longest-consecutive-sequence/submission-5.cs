public class Solution {
    public int LongestConsecutive(int[] nums)
{
    var length = nums.Length;
    if (length == 0) return 0;

    for(var i = 0; i < length - 1; i++)
    {
        var swaped = false;
        for (var j = 0; j < length - 1; j++)
        {

            if (nums[j] > nums[j + 1])
            {
                var temp = nums[j];
                nums[j] = nums[j + 1];
                nums[j + 1] = temp;
                swaped = true;
            }
        }
        if (!swaped) break;
    }

    int res  = 1;
    int streak = 1;
    for (var i = 0; i < length -1; i++)
    {
        if (nums[i] + 1 == nums[i + 1])
        {
            streak++;
        }
        else if(nums[i + 1] == nums[i])
        {
            continue;
        }
        else
        {
            nums[i] = nums[i + 1];
            if (streak > res)
            {
                res = streak;
            }
                streak = 1;
        }
    }
    if (streak > res)
        res = streak;

    return res;
}
}
