public class Solution {
    public bool IsValid(string s)
{
    if (s.Length % 2 != 0)
        return false;

    var dictBrackets = new Dictionary<char, char>()
    {
            {'}','{'},
            {')','('},
            {']','['},
        };

    var stack = new List<char>();
    for (var i = 0; i < s.Length; i++)
    {
        if (s[i] == '(' || s[i] == '[' || s[i] =='{')
            stack.Add(s[i]);
        else if (stack.LastOrDefault() == dictBrackets[s[i]])
            stack.RemoveAt(stack.Count() - 1);
        else
            return false;
    };

    if(stack.Count() != 0) return false;
    return true;
}
}
