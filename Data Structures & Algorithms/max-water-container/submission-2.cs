
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
            var length = Math.Min(heights[l], heights[r]);
            var currArea = length * (r - l);
            var currVol = currArea * length;

            maxArea = Math.Max(currArea, maxArea);
            maxVol = Math.Max(currVol, maxVol);

            if (heights[r] > heights[l])
                l++;
            else
                r--;


        }
        return maxArea;
    }
}
