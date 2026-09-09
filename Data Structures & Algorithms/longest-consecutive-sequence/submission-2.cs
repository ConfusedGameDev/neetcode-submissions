public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        if(nums.Length==0 || nums== null) 
        return 0;
         List<int> ordered= new List<int>();
        foreach(var n in nums)
        {
            if(ordered.Contains(n))
            continue;
            ordered.Add(n);
        }
       

        ordered.Sort();

       
        int currentMax =1;
        int lastMax=0;
        for(int i=0; i< ordered.Count-1;i++)
        {
            if(ordered[i+1]-1== ordered[i])
            {
                currentMax++;
            }
            else 
            {
                if(currentMax>lastMax)
                lastMax=currentMax;
                currentMax=1;
                
            }
        }
        //Console.WriteLine($"{currentMax}, {lastMax}");
        return lastMax==0? currentMax: lastMax>currentMax? lastMax:currentMax;
    }
}
