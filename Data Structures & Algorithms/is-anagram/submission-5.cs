public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        if(s.Length!= t.Length)
            return false;
        Dictionary<char, int> letters= new Dictionary<char,int>();
        for(int i=0; i<s.Length; i++)
        {
             if(!letters.Keys.Contains(s[i]))
            letters[s[i]]=1;
            else
            letters[s[i]]+=1;
           // Console.WriteLine($"value {s[i]} is {letters[s[i]]}");
        }

        for(int i=0; i<t.Length; i++)
        {
            if(!letters.Keys.Contains(t[i]))
            return false;
            else
            {
                letters[t[i]]-=1;
               // Console.WriteLine($"value {t[i]} is {letters[t[i]]}");
                if(letters[t[i]]<=0)
            {
// Console.WriteLine($" removing value {t[i]}");
                letters.Remove(t[i]);
            }
                
            }
           

            
        }
        return true;

    }
}
