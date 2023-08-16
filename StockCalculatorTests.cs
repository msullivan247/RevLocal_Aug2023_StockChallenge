using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RevLocal_Aug2023_StockChallenge;

[TestClass]
public class StockCalculatorTests
{
    [DataTestMethod]
    [DataRow(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [DataRow(new[] { 7, 5, 3, 6, 4 }, 3)]
    [DataRow(new[] { 7, 1, 5, 3, 4 }, 4)]
    [DataRow(new[] { 7, 1, 5, 3, 6, 4, 7, 1, 9, 3, 6, 2 }, 8)]
    [DataRow(new[] { 7, 5, 4 }, 0)]
    [DataRow(new[] { 4 }, 0)]
    public void GetGreatestPossibleProfit_ReturnsGreatestProfitIfPossible(IList<int> stockPrices, int expectedProfit)
    {
        StockCalculator.GetGreatestPossibleProfit(stockPrices).Should().Be(expectedProfit);
    }
}
