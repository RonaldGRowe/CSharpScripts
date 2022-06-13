class StockPrices
{
    public static void Main()
    {
        int[] Prices = { 5, 6, 3, 4, 1, 2, };
        Console.WriteLine(StockPriceGain(Prices));
    }

    public static int StockPriceGain(int[] Prices)
    {
        List<int> Buy = new() { };
        List<int> Sell = new() { };
        int i = 0;

        while (i < Prices.Length)
        {
            if (Buy.Count == Sell.Count)
            {
                if (i+1 == Prices.Length)
                {
                    break;
                }
                else if (Prices[i] < Prices[i+1])
                {
                    Buy.Add(Prices[i]);
                }
                else
                {
                    i++;    
                }

            }
            else
            {
                if (i+1 == Prices.Length)
                {
                    Sell.Add(Prices[i]);
                    i++;
                }
                else if (Prices[i] > Prices[i+1])
                {
                    Sell.Add(Prices[i]);
                }
                else
                {
                    i++;
                }
            }
        }

        if (Prices.Length == 0)
        {
            return 0;
        }
        return (Sell.Sum()-Buy.Sum());

    }
}