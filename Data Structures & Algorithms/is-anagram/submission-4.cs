public class Solution {
    public bool IsAnagram(string s, string t)
{
    if(s.Length != t.Length)
        return false;
    List<char> arr = new List<char> { };
    char[] arr2 = new char[] { };
    foreach (var c in s)
    {
        arr.Add(c);
    }
    foreach (var c in t)
    {
        arr.Remove(c);
    }

    return arr.Count() == 0;
}
}
