public class Solution {
    public bool IsPalindrome(string s)
    {
        var adjustedSring = string.Join("", s.ToLower().Where(x => Char.IsLetterOrDigit(x)));

        var first = adjustedSring.Substring(0, adjustedSring.Length / 2);
        var second = string.Join("", adjustedSring.Substring((int)Math.Round(adjustedSring.Length / 2.0, MidpointRounding.ToPositiveInfinity)).Reverse());

        return first == second;
    }

}
