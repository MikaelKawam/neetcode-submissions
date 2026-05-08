public class Solution {
    public bool IsValid(string s) {
    Stack<char> stack = new Stack<char>();
    var dictOpenClosedBrackets = new Dictionary<char, char>()
    {
       {')','('},
       {'}','{'},
       {']','['},
    };
    foreach(char c in s)
    {
        if (dictOpenClosedBrackets.ContainsKey(c) == true)
        {
            if (stack.Count > 0 && stack.Peek() == dictOpenClosedBrackets[c])
                stack.Pop();
            else
                return false;
        } 
        else
            stack.Push(c);
    }

    if(!stack.Any()) return true;
        
    return false;
}
}
