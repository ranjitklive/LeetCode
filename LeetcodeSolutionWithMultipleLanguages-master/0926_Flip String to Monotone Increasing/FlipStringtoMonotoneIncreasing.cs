public class Solution {
    public int MinFlipsMonoIncr(string S) {
        var sLen = S.Length;
        var l = new int[sLen];
        var r = new int[sLen];
        l[0] = S[0] - '0';
        r[sLen-1] = '1' - S[sLen-1];

        for(int i=1;i<sLen;i++){
            l[i] = l[i-1] + (S[i] - '0');
        }       

        for(int i=sLen-2;i>=0;i--){
            r[i] = r[i+1] + ('1' - S[i]);
        }

        //the case all 1's (r[0]) or all 0's (l[sLen-1])
        int ans = Math.Min(r[0], l[sLen-1]); 
        for(int i=1;i<sLen;i++){
            ans = Math.Min(ans, l[i-1] + r[i]);
        }

        return ans;
    }
}