public class Solution {
    public bool IsPalindrome(string s)
    {
        var adjustedSring = string.Join("", s.ToLower().Where(x => Char.IsLetterOrDigit(x)));

        return adjustedSring == string.Join("",adjustedSring.Reverse());
    }

}
