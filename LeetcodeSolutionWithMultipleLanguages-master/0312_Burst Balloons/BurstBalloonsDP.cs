public class Solution {
    private int[] vals;
    private int[,] DP;
    
    public int MaxCoins(int[] nums) {
        var n = nums.Length;
        DP = new int[n+2, n+2];
        vals = new int[n+2];
        vals[0] = vals[n+1] = 1;
        
        for(int i=0;i<n;i++)
        {
            vals[i+1] = nums[i];
        }
        
        for(int l = 1;l<= n; l++)
        {
            for(int i=1;i+l <= n+1; i++)
            {
                int j = i + l - 1;
                int most = 0;
                for(int k = i; k <= j;k++)
                {
                    most = Math.Max(most, DP[i,k-1] + vals[i-1] * vals[k] * vals[j+1] + DP[k+1,j]);
                }
                
                DP[i,j] = most;
            }
        }
        
        return DP[1,nums.Length];
    }
}