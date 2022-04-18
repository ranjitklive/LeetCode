
public class Solution {
    public boolean canPlaceFlowers(int[] flowerbed, int n) {
        int ans = 0;
        for(int i=0;i<flowerbed.length;i++){
            if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.length - 1 || flowerbed[i + 1] == 0)) {
                flowerbed[i++] = 1;
                ans++;
            }
             if(ans>=n)
                return true;
        }
        return false;
    }
}