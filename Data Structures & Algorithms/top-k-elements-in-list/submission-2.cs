public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> frequencyChart= new();

        foreach(var n in nums)
        {
            if(!frequencyChart.ContainsKey(n))
                frequencyChart[n]=1;
            else
            frequencyChart[n]+=1;
        }

        List < KeyValuePair<int,int> > list = new List<KeyValuePair<int,int>>   (frequencyChart);
       
        list.Sort((a, b) => a.Value.CompareTo(b.Value));
        list.Reverse();

        if(list.Count<k)
        {
            return null;
        }
        int[] result = new int[k];
        for(int i=0; i<k; i++)
        {
            result[i]= list[i].Key;
        }
        return result;
    }
}
