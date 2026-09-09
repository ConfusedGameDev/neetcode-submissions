public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
          if (strs == null || strs.Length == 0) return null;
 Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

 for (int i = 0; i < strs.Length; i++)
 {

     int[] frequency = new int[26];
     for (int j = 0; j < strs[i].Length; j++)
     {
         frequency[strs[i][j] - 'a']++;
     }
     StringBuilder stringBuilder = new StringBuilder();
     foreach (var a in frequency)
     {
         stringBuilder.Append(a.ToString());
          stringBuilder.Append("#");
     }

     if (!anagrams.ContainsKey(stringBuilder.ToString()))
     {
         anagrams.Add(stringBuilder.ToString(), new List<string>());
     }
     anagrams[stringBuilder.ToString()].Add(strs[i]);
 }
 List<List<string>> result = new List<List<string>>();
 foreach (var a in anagrams.Keys)
 {

     result.Add(anagrams[a]);
 }


 return result;
 

    }
}
