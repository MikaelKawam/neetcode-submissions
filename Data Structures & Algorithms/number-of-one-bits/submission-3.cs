
public class Solution
{
    public int HammingWeight(uint n)
    {
        uint count = 0;
        uint one = 1;
        while (n > 0)
        {
            count += n & one;
            n = n >> 1;
        }

        return (int)count;
    }
}