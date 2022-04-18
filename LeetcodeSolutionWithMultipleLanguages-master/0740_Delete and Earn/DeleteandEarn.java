class Solution {
    public int deleteAndEarn(int[] nums) {
        int max = Arrays.stream(nums).max().getAsInt();
        int[] earns = new int[max+1];
        
        for(int e : nums) {
            earns[e] += e;
        }
        
        int n = earns.length;
        if(n <= 1) return 0;
        if(n == 2) return earns[1];
        if(n == 3) return Math.max(earns[1], earns[2]);
        
        int prev2 = earns[1];
        int prev1 = Math.max(earns[1], earns[2]);
        for(int i=3;i<n;i++)
        {
            int curr = Math.max(prev2 + earns[i], prev1);
            prev2 = prev1;
            prev1 = curr;
        }
        
        return prev1;
    }
}