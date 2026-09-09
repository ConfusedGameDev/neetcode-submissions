public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
         if (strs == null || strs.Length == 0) return null;
 Dictionary<string, List<int>> anagrams = new Dictionary<string, List<int>>();

 for(int i=0;i<strs.Length; i++)
 {
     var charArray = strs[i].ToCharArray();
      Array.Sort(charArray);
     string sortedString="";
     foreach (var item in charArray)
     {
         sortedString+=item;
     }
     if (!anagrams.ContainsKey(sortedString))
     {
         anagrams.Add(sortedString, new List<int>());
     }
     anagrams[sortedString].Add(i);
 }
List<List<string>> result = new List<List<string>>();
 foreach (var a in anagrams.Keys)
 {
     List<string> anagramCount = new List<string>();
     foreach (var index in anagrams[a])
     {
         anagramCount.Add(strs[index]);
     }
     result.Add(anagramCount);
 }

        return result;


    }
}
