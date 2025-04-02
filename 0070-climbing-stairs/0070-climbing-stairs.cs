public class Solution {
    public int ClimbStairs(int n) {
        int p = 0;
        int c = 1;

        for(int i = 1; i <= n; i++){
            c = c + p;
            p = c - p;
        }

        return c;
    }
}