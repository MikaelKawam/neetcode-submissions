public class Solution {
    public bool IsValid(string s) {
    if (s.Length < 2) return false;

    var stack = new List<char>();
    var openBrackets = new List<char>()
    {
        '(','{','['
    };
    var dictOpenClosedBrackets = new Dictionary<char, char>()
    {
       {')','('},
       {'}','{'},
       {']','['},
    };

    foreach(char c in s)
    {
        if (openBrackets.Contains(c) == true)
            stack.Add(c);
        else
        {
            var lastChar = stack.Count()-1;
            if ((lastChar >= 0) && (stack[lastChar] == dictOpenClosedBrackets[c]))
            {
                stack.RemoveAt(lastChar);
            }
            else
            {
                return false;
            }
        }
    }

    if(!stack.Any()) return true;
        
    return false;
}
}
