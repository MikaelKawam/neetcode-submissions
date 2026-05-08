public class Solution {
    public int MaxProfit(int[] prices) {
        var maxProfit = 0;
        int lowP = prices[0], highP = prices[0];
        foreach(int p in prices)
        {
            if(p < lowP) 
            {
                lowP = p;
                highP = 0;
            }
            else if(p > highP)
            {
                highP = p;
            }
              
            var currentProfit = highP - lowP;
            if(currentProfit > maxProfit)
                maxProfit = currentProfit;
        }

        return maxProfit;
    }
}
