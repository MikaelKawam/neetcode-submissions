public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var dictMissVal = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            var missing = target - nums[i];
            if (dictMissVal.TryGetValue(missing, out var value))
            {
                return new int[] { value, i };
            }
            
            dictMissVal[nums[i]] = i;
        }

        return null;
    }
}