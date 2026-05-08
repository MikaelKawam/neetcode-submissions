public class Solution
{
    public string Encode(IList<string> strs)
    {
        var str = string.Empty;
        foreach (string s in strs)
        {
            str += s.Length + "#" + s;
        }
        return str;
    }

    public List<string> Decode(string s)
    {
        var list = new List<string>();
        var i = 0;
        while(i < s.Length)
        {
            string size = string.Empty;
            while (s[i] != '#')
            {
                size += s[i];
                i++;
            }
            var sizeInt = int.Parse(size.ToString());
            i += 1;
            list.Add(s.Substring(i, sizeInt));
            i += sizeInt;
        }
        return list;
    }
}