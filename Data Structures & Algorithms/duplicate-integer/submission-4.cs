public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> myNums = new Dictionary<int,int>();

        for (int i =0; i< nums.Length; i++)
        {
            if(myNums.ContainsKey(nums[i]))
                return true;
            myNums[nums[i]] =1;

        }

        return false;
    }
}