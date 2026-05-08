public class Solution {
    public bool hasDuplicate(int[] nums)
    {
        var hashInt = new HashSet<int>();
        foreach(var num in nums)
        {
            if (hashInt.TryGetValue(num, out var _))
                return true;

            hashInt.Add(num);
        }

        return false;
    }
}
