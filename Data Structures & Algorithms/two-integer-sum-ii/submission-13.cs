public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
        
        int x= 0;
        int y=numbers.Length-1;

        while(x<y)
        {
            if(numbers[x]+numbers[y]== target)
            {
                return new int[]{x+1,y+1};
            }
            if(numbers[x]+numbers[y]>target)
            {
                y--;
            }
            else
            {
                x++;
            }

        }
        
        return new int[]{};
    }

  

}
