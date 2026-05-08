public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        int lowP = prices[0];

        for(int i = 1; i < prices.Length; i++)
        {
            int p = prices[i];
            
            int currentProfit = p - lowP;
            if(currentProfit > maxProfit) maxProfit = currentProfit;
        
            if(p < lowP) lowP = p;
        }

        return maxProfit;
    }
}
