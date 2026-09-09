public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int, int> frequencyChart = new Dictionary<int, int>();
        List<int> result = new List<int>();
         int currentMax = -1;

 
 for (int i = 0; i < nums.Length; i++)
 {
     if (frequencyChart.ContainsKey(nums[i]))
     {
         frequencyChart[nums[i]]++;

     }
     else
         frequencyChart[nums[i]] = 1;

     if(frequencyChart[nums[i]]>=currentMax && !result.Contains(nums[i]))
     {
         result.Add(nums[i]);
         currentMax= frequencyChart[nums[i]];
         int minMember = -1;
         if(result.Count>k)
         {
             int min = int.MaxValue;
             for (int j = 0;j<result.Count;j++)
             {
                 if (frequencyChart[result[j]] <min)
                 {
                     minMember=result[j];
                     min= frequencyChart[result[j]];
                 }
             }
             result.Remove(minMember);
         }
     }
 }
 
 return result.ToArray();


        
    }
}
