public class Solution {
    public int LongestConsecutive(int[] nums)
{
    /* brute force solution would be to consider every element from the array as the start of the sequence and count the length of the sequence formed with that starting element. This would be an O(n ^ 2) solution.Can you think of a better way ?
       */
    var length = nums.Length;
    var max = 0;
    for(var i = 0; i < length; i++)
    {
        var count = 1;
        var nextValue = nums[i];
        for (var j = 0; j < length; j++)
        {
            if ((nextValue + 1) == nums[j])
            {
                nextValue++;
                count++;
                j = -1;
            }
        }
     
        if (count > max)
        {
            max = count;
            if (count == length)
            {
                break;
            }
        }
    }

    return max;
}
}
