public class Solution {
    public bool hasDuplicate(int[] nums)
{
      if (nums == null || nums.Length == 0) return false;
  int startIndex = 0;
  var x = nums[0];
  for (int i = startIndex + 1; i < nums.Length; i++)
  {
     // Debug.Log($"is {x} the same as {nums[i]}");
      if (nums[i] == x)
          return true;
      if (i + 1 == nums.Length && startIndex < nums.Length  )
      {
          startIndex++;
          i = startIndex ;
          x = nums[startIndex];
      }

  }

  return false;
}
}