public IList<IList<string>> GroupAnagrams(string[] strs) {
    var map = new Dictionary<string, List<string>>();

    foreach (var str in strs) {
        var chars = str.ToCharArray();
        Array.Sort(chars);
        var key = new string(chars);

        if (!map.ContainsKey(key)) map[key] = new List<string>();
        map[key].Add(str);
    }

    return map.Values.ToList<IList<string>>();
}
