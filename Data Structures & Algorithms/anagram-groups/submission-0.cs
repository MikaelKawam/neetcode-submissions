public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

    var dict = new Dictionary<string, List<string>>();
    foreach (var s in strs)
    {
        char[] sSort = s.ToCharArray();
        Array.Sort(sSort);
        var key = new string(sSort);
        dict[key] = (dict.GetValueOrDefault(key) ?? Enumerable.Empty<string>())
                .Append(s)
                .ToList();
    }

    return dict.Select(x => x.Value.ToList()).ToList();
}
}
