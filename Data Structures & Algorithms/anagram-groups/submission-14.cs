public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
         
        List<List<string>> result= new();
        List<int[]> map = new();
        int mapIndex=0;
        List<int> invalidIndex= new();
        foreach(var str in strs)
        {
            map.Add(new int[26]);
            foreach(char c in str)
            {
                int index=c-'a';
                map[mapIndex][index] += 1;
               // Console.WriteLine($"the word contains {c} index {index}");
            }
            mapIndex++;
        }

        int resultIndex=0;
        for(int i=0;i<strs.Length; i++)
        {
            if(invalidIndex.Contains(i))
            continue;
            result.Add(new List<string>());
            result[resultIndex].Add(strs[i]);
            invalidIndex.Add(i);
            for (int j= i+1; j<strs.Length; j++)
            {
             //   Console.WriteLine($"Comparing {strs[i]} and {strs[j]} {map[i]== map[j]}");
                if(strs[i].Length!= strs[j].Length) 
                continue;
                bool addToList=true;
                for(int k=0; k<strs[i].Length; k++)
                {
                    int ind= k;
                    int x= strs[i][k]-'a';
                    int y=strs[j][k]-'a';
                   // Console.WriteLine($"map {x} {y}");
                    if(map[i][x]!=map[j][x])
                   {
                    addToList=false;
                     break;
                   }
                }
                if(addToList)
                {
               // Console.WriteLine($"Adding {strs[j]}");
                result[resultIndex].Add(strs[j]);
                invalidIndex.Add(j);
                }
                
            }
            resultIndex++;
        }

        return result;
        
    }
}
