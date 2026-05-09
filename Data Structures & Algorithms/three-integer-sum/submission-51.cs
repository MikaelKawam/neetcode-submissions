public class Solution {
    public List<List<int>> ThreeSum(int[] nums)
{
    var length = nums.Length;
    Array.Sort(nums);

    var list = new List<List<int>>();
    var fixated = 0;
    int left = 1, right = length - 1;
    while (left < right)
    {
        var sum = nums[fixated] + nums[left] + nums[right];
        if (sum == 0)
        {
            var triplet = new List<int> { nums[fixated], nums[left], nums[right] };
            if (!list.Any(x => x.SequenceEqual(triplet))) list.Add(triplet);
            right--;
            left++;
        }
        else if (sum < 0) left++;
        else right--;

        if (left >= right)
        {
            fixated++;
            left = fixated + 1;
            right = length - 1;
        }
    }

        return list;
}
}
