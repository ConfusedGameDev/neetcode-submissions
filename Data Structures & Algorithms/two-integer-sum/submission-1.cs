public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        if(nums== null || nums.Length<=1) return null;
         Dictionary<int, int> diff = new Dictionary<int, int>();
        int first = -1;
int second = -1;
for (int i = 0; i < nums.Length; i++)
{
    if (!diff.ContainsKey(nums[i]))
        diff.Add(nums[i], i);
    else if (target - nums[i] == nums[i])
    {
        return new int[] { diff[nums[i]], i };
    }

}

for (int i= 0; i < nums.Length; i++)
{
    if (diff.ContainsKey(target - nums[i])&& target-nums[i]!= nums[i] )
    {
        first = i;
        second = diff[target - nums[i]];

        return new int[] { first, second };
    }
}

return null;
    }
}
