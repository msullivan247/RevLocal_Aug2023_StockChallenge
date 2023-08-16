namespace RevLocal_Aug2023_StockChallenge;

public class StockCalculator
{
    public static int GetGreatestPossibleProfit(IList<int> stockPrices)
    {
        if (stockPrices.Count <= 1)
        {
            return 0;
        }

        var firstPrice = stockPrices.First();
        var remainingPrices = stockPrices.Skip(1).ToArray();

        var possibleProfit = Math.Max(remainingPrices.Max() - firstPrice, 0);

        return Math.Max(possibleProfit, GetGreatestPossibleProfit(remainingPrices));
    }
}