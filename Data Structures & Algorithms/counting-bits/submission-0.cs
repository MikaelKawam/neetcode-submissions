public class Solution
{
    public int[] CountBits(int n)
    {
        var res = new int[n + 1];
        while (n >= 0)
        {
            var count = 0;
            for (int i = 0; i < 32; i++)
            {
                var bit = (n >> i) & 1;
                count += (int)(bit & 1);
            }
            res[n] = count;
            n--;
        }

        return res;
    }
}