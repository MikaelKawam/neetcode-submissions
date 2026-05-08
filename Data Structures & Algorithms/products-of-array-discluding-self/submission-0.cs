public class Solution {
    public int[] ProductExceptSelf(int[] nums)
{

    var idx = 0;
    var resArr = new int[nums.Length];
    for(var i = 0; i < nums.Length; i++)
    {
        resArr[i] = 1;
    }

    var currIdx = 0;
    while(currIdx < nums.Length)
    {
        if (idx != currIdx)
        {
            resArr[currIdx] *= nums[idx];
        }
        idx++;
        if (idx == nums.Length)
        {
            currIdx++;
            idx = 0;
        }
    }
    return resArr;
}
}
