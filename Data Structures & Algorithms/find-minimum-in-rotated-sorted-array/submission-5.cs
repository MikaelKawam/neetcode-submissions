public class Solution
{
    public int FindMin(int[] nums)
    {
        int l = 0, r = nums.Length - 1;
        while (l < r)
        {
            var m = l + (r - l) / 2;

            if (nums[m] > nums[r])
                l = m + 1;
            else if (nums[m] < nums[r])
                r = m;
           
        }

        Console.WriteLine(nums[r]);
        return nums[r];
    }
}