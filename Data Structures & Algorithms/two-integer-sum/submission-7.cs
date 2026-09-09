public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int,int> difference = new ();
        Dictionary<int,int> original = new ();

        for(int i=0; i<nums.Length; i++)
        {  
           original[nums[i]]=i;          
           difference[target-nums[i]]=i;
           
           //5,0 4,1 6,2
           //5,0  6,1  4,2    
        }

        int x=0;
        foreach(var k in difference.Keys)
        {
            if(original.Keys.Contains(k) && x!= original[k])
            {
                return new int[]{x,original[k]};
            }
            x++;

        }

        return null;

    }
}
