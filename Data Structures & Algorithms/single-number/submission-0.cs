public class Solution {
    public int SingleNumber(int[] nums)
    {
        HashSet<int> hash = new HashSet<int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if(hash.Add(nums[i]) == false)
                hash.Remove(nums[i]);
        }

        return hash.First();
    }
}
