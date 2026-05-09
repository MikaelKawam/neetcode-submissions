public class Solution {
    public List<List<int>> ThreeSum(int[] nums)
{
    var length = nums.Length;
    for (var i = 0; i < length; i++)
    {
        bool swapped = false;
        for (var j = 0; j < length - 1 - i; j++)
        {
            if (nums[j] > nums[j + 1])
            {
                var temp = nums[j];
                nums[j] = nums[j + 1];
                nums[j + 1] = temp;
                swapped = true;
            }
        }

        if (!swapped) break;
    }

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
