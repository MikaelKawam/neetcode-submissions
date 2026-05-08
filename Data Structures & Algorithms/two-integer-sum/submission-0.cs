public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        var dictKeyTarget = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var remainTarget = target - nums[i];
            if (dictKeyTarget.TryGetValue(remainTarget, out var _))
                return new int[] { dictKeyTarget[remainTarget], i };

            dictKeyTarget[nums[i]] = i;
        }

        return new int[0];
    }
}
