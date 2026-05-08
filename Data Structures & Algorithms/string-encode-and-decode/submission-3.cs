public class Solution
{
    private const char Separator = '\u001F';
    public string Encode(IList<string> strs)
    {
        if (strs.Count == 0) return string.Empty;
        var str = string.Empty;
        for(var i = 0; i < strs.Count; i++)
        {
            for(var j = 0; j < strs[i].Length; j++)
            {
                str += strs[i][j];
            }
            str += Separator;
        }

        return str;
    }

    public List<string> Decode(string s)
    {
        var list = new List<string>();
        var str = string.Empty;
        for(var i = 0; i < s.Length; i++)
        {
            if (s[i] == Separator)
            {
                list.Add(str);
                str = string.Empty;
            }
            else
            {
                str += s[i];
            }
        }

        return list;
    }
}
