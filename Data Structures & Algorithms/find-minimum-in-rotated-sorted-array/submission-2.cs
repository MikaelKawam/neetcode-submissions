public class Solution
{
    public int FindMin(int[] nums)
    {
        int l = 0, r = nums.Length - 1;

        var m = 0;
        var find = 0;
        while (l < r)
        {
            m = l + (r - l) / 2;

            if (nums[m] > nums[r])
            {
                l = m + 1;
                find = r; 
            }
            else if (nums[m] < nums[r])
            {
                r = m;
                find = l;
            }
           
        }

        Console.WriteLine(nums[find]);
        return nums[find];
    }
}