public class Solution {
    public int MaxProfit(int[] prices) {
        var maxProfit = 0;
        var low = prices[0];
        var high = prices[0];
        foreach(int p in prices)
        {
            if(p < low) 
            {
                low = p;
                high = 0;
            }
            else if(p > high)
            {
                high = p;
            }
              
            var tempProfit = high - low;
            if(tempProfit > maxProfit)
                maxProfit = tempProfit;
        }

        return maxProfit;
    }
}
