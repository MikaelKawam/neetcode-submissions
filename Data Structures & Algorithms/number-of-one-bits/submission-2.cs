
public class Solution
{
    public int HammingWeight(uint n)
    {
        int onecounter = 0;
        string mystring = Convert.ToString(n, 2);

        foreach (char c in mystring)
        {
            if(c == '1')
                onecounter ++;

        }

        return onecounter;
}
}