public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
{
    var dictKCount = new Dictionary<int, int>();
    for (var i = 0; i < nums.Length; i++)
    {
        dictKCount[nums[i]] = dictKCount.TryGetValue(nums[i], out var value) ? value + 1 : 0 + 1;
    }

    var result = dictKCount.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
    return result;
}
}
