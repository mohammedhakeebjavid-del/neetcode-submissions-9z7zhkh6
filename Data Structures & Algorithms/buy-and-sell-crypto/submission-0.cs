public class Solution {
    public int MaxProfit(int[] prices) {
        int n=prices.Length;
        int minPrice=int.MaxValue;
        int maxprof=0;
        foreach (int price in prices)
        {
            if(price< minPrice)
            {
                minPrice=price;
            }
            else
        {

    
            maxprof=Math.Max(maxprof,price-minPrice);
        }
        }
        return maxprof;
    }
}
