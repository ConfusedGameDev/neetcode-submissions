public class Solution {
    public List<List<int>> ThreeSum(int[] nums) 
    {
        List<List<int>> result = new();
        List<int> numsL= new List<int>(nums);
        numsL.Sort();
        

        for(int i=0; i<numsL.Count-2  ;  i++)
        {
            if (i>0 && numsL[i]== numsL[i-1])
            continue;
           
            int x=i+1;
           
            int y= numsL.Count-1;
            while(x<y )
            {
                if((numsL[x]+numsL[y]+numsL[i])<0)
                {
                    x++;
                    continue;
                }
                else if((numsL[x]+numsL[y]+numsL[i])>0)
                {
                    y--;
                    continue;
                }
                else
                {  
                    
                 
                     result.Add(new List<int>(new int[]{numsL[i],numsL[x],numsL[y]}));
                   
                    while (x+1<y && numsL[x]== numsL[x+1])
                        x++;
                    x++;
                    y--;
                 }
            }

        }
       return  result;
    }
}
