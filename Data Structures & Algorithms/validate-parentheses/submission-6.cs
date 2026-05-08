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

    // Stacks.
    var stack = new List<char>();
    var openBrackets = new List<char>() { '(', '[', '{' };
    for (var i = 0; i < s.Length; i++)
    {
        if (openBrackets.Contains(s[i]))
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
