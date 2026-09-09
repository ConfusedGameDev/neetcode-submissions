public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        var prod=1;
        foreach(var n in nums)
        {
            prod*=n;
        }

        int[] result = new int[nums.Length];

        for(int i = 0; i<nums.Length; i++)
        {
            if(nums[i]!=0)
            result[i]= prod/nums[i];   
            else
            {
                result[i]=1;
                for(int j=0; j<nums.Length; j++)
                {
                    if(j== i)
                    continue;
                    result[i]*=nums[j];
                }
            }
        }
        
        return result;
    }
}
