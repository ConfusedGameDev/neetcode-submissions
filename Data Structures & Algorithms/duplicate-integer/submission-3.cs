public class Solution 
{
    public bool hasDuplicate(int[] nums)
{
    if (nums == null|| nums.Length == 0) return false;
Dictionary<int, int> values= new Dictionary<int, int>();
for (int i = 0; i < nums.Length; i++)
{
    if (values.ContainsKey(nums[i])) return true;

    values.Add(nums[i], nums[i]);


}
return false;
}
}