public class Solution {
    public bool IsPalindrome(string s) 
    {
        Queue<char> leftToRight= new ();
        Stack<char> rightToLeft= new ();

 
        s= s.ToUpper();
        for(int i=0; i< s.Length;i++)
        {
            var next = s[i];
            if((next>=48 && next<58) || (next>=65 && next<91) )
            {
                //Console.WriteLine($"Adding {next}");
             leftToRight.Enqueue(next);
            rightToLeft.Push(next);
            }
            else
            {
                // Console.WriteLine($"ignoring {next}");
            }
           


        }

     
       while(leftToRight.Count>0)
        {
            var x= leftToRight.Dequeue();
            var y = rightToLeft.Pop();

           // Console.WriteLine($"Comparing {x}, {y}");
            if(x!=y)
            return false;
        }
        return true;
        
    }
}
