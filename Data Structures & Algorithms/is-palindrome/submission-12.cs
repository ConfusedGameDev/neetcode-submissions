public class Solution {
    public bool IsPalindrome(string s) 
    {
        
 
        s= s.ToUpper();
        int revI= s.Length-1;
        for(int i=0; i< s.Length;i++)
        {
            
           // Console.WriteLine($"{i}, {revI}");
            while(i<s.Length && !char.IsLetterOrDigit(s[i]))
            {
                  i++;
               // Console.WriteLine($"A{i}, {revI}");

            }
          
            while(revI>0 && !char.IsLetterOrDigit(s[revI]))
            {
                revI--;
              //  Console.WriteLine($"B{i}, {revI}");
            }
            
             if(i>=s.Length || revI<0)
            break;
            var next = s[i];

            var next2= s[revI];

            
            if((next>=48 && next<58) || (next>=65 && next<91) )
            {
                Console.WriteLine($"Comparing {s[i]},{s[revI]}");
               if(s[i]!= s[revI])
               return false;
               
               
                
            
            }
            else
            {
                continue;
            }
           
           
            revI--;


        }

     
        
        return true;
        
    }

    
}
