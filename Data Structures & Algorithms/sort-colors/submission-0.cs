public class Solution {
    public void SortColors(int[] nums)
{

    for (var i = 0; i < nums.Length -1; i++)
    {
        for (var j = i + 1; j <= nums.Length -1; j++)
        {

            if(nums[i] > nums[j])
            {
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }
    }
}
}