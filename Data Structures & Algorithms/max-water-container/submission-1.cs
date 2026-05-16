
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
            if (heights[r] > heights[l])
            {
                var diff = heights[r] - heights[l];
                var currVol = heights[l] * (heights[r] - diff) * (r - l);

                if (currVol > maxVol)
                {
                    maxArea = Math.Max((r - l) * (heights[r] - diff), maxArea);
                    maxVol = Math.Max(currVol, maxVol);
                }
                    l++;
            }
            else 
            {
                var diff = heights[l] - heights[r];
                var currVol = (heights[l] - diff) * heights[r] * (r - l);
                if (currVol > maxVol)
                {
                    maxArea = Math.Max((heights[l] - diff) * (r - l), maxArea);
                    maxVol = Math.Max(currVol, maxVol);
                }
                    r--;
            }
        }
        return maxArea;
    }
}
