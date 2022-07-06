public class Solution
{
    public int MaxProfit(int[] prices)
    {
        var profit = 0;
        var current = 0;
        var sellCheck = 0;

        //While list is indexable
        for (var i = 0; i < prices.Length - 1; i++)
        {
            //Buy if next value is larger
            if (sellCheck == 0)
            {
                if (prices[i] < prices[i + 1])
                {
                    current = prices[i];
                    sellCheck++;
                }
            }
            if (sellCheck > 0)
            {//Sell if next value is smaller
                if (prices[i + 1] > current)
                {
                    profit += prices[i + 1] - current;
                    current = 0;
                    sellCheck = 0;
                }
            }
        }
        return profit;


    }
}