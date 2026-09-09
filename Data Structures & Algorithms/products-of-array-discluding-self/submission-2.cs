public class Solution {
    public int[] ProductExceptSelf(int[] nums) 
    {
        var prod=1;
        int zeros=0;
        foreach(var n in nums)
        {
            if(n==0)
            zeros++;
            prod*=n;
        }

        int[] result = new int[nums.Length];

        for(int i = 0; i<nums.Length; i++)
        {
            if(nums[i]!=0)
            result[i]= prod/nums[i];   
            else if(zeros==1)
            {
                result[i]=1;
                for(int j=0; j<nums.Length; j++)
                {
                    if(j== i)
                    continue;
                    result[i]*=nums[j];
                }
            }
            else
            result[i]=0;
        }
        
        return result;
    }
}
