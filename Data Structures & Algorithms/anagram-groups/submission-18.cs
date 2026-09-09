public class Solution 
{
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        Dictionary<string,List<string>>map = new();
        foreach(var v in strs)
        {
            int [] keys =new int[26];
            foreach(var c in v)
            {
                keys[c-'a']+=1;

            }
            var s = string.Join(",",keys);
            if(!map.ContainsKey(s))
            map[s]=new List<string>();
            map[s].Add(v);

        }
        return new List<List<string>>(map.Values);
    }
}
