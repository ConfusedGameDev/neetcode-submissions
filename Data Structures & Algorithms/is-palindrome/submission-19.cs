public class Solution {
    public bool IsPalindrome(string s) 
    {
        
 
        s= s.ToUpper();
        int revI= s.Length-1;
        int i=0;
        while(i<revI)
        {
            
           // Console.WriteLine($"{i}, {revI}");
            if( !char.IsLetterOrDigit(s[i]))
            {
                  i++;
                  continue;
               // Console.WriteLine($"A{i}, {revI}");

            }
          
            while( !char.IsLetterOrDigit(s[revI]))
            {
                revI--;
                continue;
              //  Console.WriteLine($"B{i}, {revI}");
            }
            
            
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
            i++;


        }

     
        
        return true;
        
    }

    
}
