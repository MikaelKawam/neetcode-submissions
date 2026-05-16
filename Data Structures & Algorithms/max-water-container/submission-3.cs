public class Solution
{
    public int MaxArea(int[] heights)
    {
        var size = heights.Length - 1;
        int l = 0, r = size;
        var maxArea = 0;
        var maxVol = 0;

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
