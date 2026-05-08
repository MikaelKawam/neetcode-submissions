public class Solution {
    public int[] TwoSum(int[] nums, int target) {
    var dictMissValueToTarge = new Dictionary<int, int>();
    for (var i = 0; i < nums.Length;  i++)
    {
        if (dictMissValueToTarge.ContainsKey(nums[i]))
        {
            return new int[] { dictMissValueToTarge[nums[i]], i };
        }
            var missValueToTarge = target - nums[i];
            dictMissValueToTarge[missValueToTarge] = i;
    }

    return new int[] {};
}
}
