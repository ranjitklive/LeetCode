public class Solution {
    public int MinimumTotal(IList<IList<int>> triangle) {
        var n = triangle.Count;
        if(n == 1) return triangle[0][0];
        
        var dp = new int[n+1];
        
        for(int i=n-1;i>=0;i--)
        {
            var list = triangle[i];
            for(int j=0;j<list.Count;j++)
                dp[j] = Math.Min(dp[j], dp[j+1]) + list[j];
            
        }
        
        return dp[0];
    }
}