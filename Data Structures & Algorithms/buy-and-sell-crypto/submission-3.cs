public class Solution {
public int MaxProfit(int[] prices)
{
    int buy = 0, sell = 1;
    int maxProfit = 0;

    while (sell <= prices.Length - 1)
    {
        if (prices[sell] > prices[buy])
        {
            int profit = prices[sell] - prices[buy];
            maxProfit = Math.Max(maxProfit, profit);
        }
        else
            buy = sell;

        sell++;
    };

    return maxProfit;
}
}