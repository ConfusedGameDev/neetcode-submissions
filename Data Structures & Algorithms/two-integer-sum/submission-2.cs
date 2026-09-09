public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {     Dictionary<int, int> diff = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
 {
     if (!diff.ContainsKey(nums[i]))
     {
         if (diff.ContainsKey(target - nums[i]))
         {
             return new int[] { diff[target - nums[i]], i };
         }
         diff.Add(nums[i], i);
     }
     else if (target - nums[i] == nums[i])
     {
         return new int[] { diff[nums[i]], i };
     }

 }


 return null;
    }
}
