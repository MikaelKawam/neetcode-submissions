public class Solution {
    public int ClimbStairs(int n) {    

        if(n <= 3) 
            return n;
        var n2 = n / 2; // 3 
        var n3 = n2 * (n - n2); // 3 * (6-3) = 6

        return ClimbStairs(n - 1) + ClimbStairs(n - 2);
    }
}
