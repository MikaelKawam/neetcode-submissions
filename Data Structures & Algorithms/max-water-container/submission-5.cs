public class Solution
{
    public int MaxArea(int[] heights)
    {
        int l = 0, r = heights.Length - 1;
        var maxArea = 0;

        while (l != r)
        {
            var currArea = Math.Min(heights[l], heights[r]) * (r - l);
            maxArea = Math.Max(currArea, maxArea);

            if (heights[r] > heights[l])
                l++;
            else
                r--;
        }
        return maxArea;
    }
}
