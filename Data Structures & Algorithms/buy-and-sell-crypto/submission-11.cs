public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int lowP = prices[0];
        foreach(int p in prices)
        {
            if(p < lowP) 
            {
                lowP = p;
            }

            int currentProfit = p - lowP;
            if(currentProfit > maxProfit)
                maxProfit = currentProfit;
        }

        return maxProfit;
    }
}
