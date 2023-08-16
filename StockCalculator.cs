namespace RevLocal_Aug2023_StockChallenge;

public class StockCalculator
{
    public static int GetGreatestPossibleProfit(IList<int> stockPrices)
    {
        var firstPrice = stockPrices.First();
        var remainingPrices = stockPrices.Skip(1).ToArray();

        if (!stockPrices.Any())
        {
            return 0;
        }

        var possibleProfit = Math.Max(remainingPrices.Max() - firstPrice, 0);

        return Math.Max(possibleProfit, GetGreatestPossibleProfit(remainingPrices));
    }
}