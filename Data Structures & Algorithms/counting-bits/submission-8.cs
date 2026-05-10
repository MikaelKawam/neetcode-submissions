public class Solution
{
    public int[] CountBits(int n)
    {
        var res = new int[n + 1];
        while (n > 0)
        {
            int num = n;
            while (num != 0) {
                res[n]++;
                num &= (num - 1);
            }
            n--;
        }

        return res;
    }
}