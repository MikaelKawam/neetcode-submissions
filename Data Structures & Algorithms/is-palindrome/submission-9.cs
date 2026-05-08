public class Solution {
    public bool IsPalindrome(string s)
    {
        if (s.Length < 2) return true;
        var adjustedSring = string.Join("", s.ToLower().Where(x => Char.IsLetterOrDigit(x)));
        var middleIdx = adjustedSring.Length / 2;

        var first = adjustedSring.Substring(0, middleIdx);
        var second = string.Join("", adjustedSring.Substring((int)Math.Round(adjustedSring.Length / 2.0, MidpointRounding.ToPositiveInfinity)).Reverse());

        return first == second;
    }

}
