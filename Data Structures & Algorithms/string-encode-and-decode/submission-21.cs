public class Solution {

    public string Encode(IList<string> strs) 
    {
        if(strs.Count==0)
        return null;
        
        return string.Join("確",strs);
        
      
    }

    public List<string> Decode(string s) 
    {
        if(s==null)
        {
            return new List<string>(); 
        }
         
        
       // Console.WriteLine(sArr.Length);
        if (s== string.Empty ||!s.Contains("確") )
        {           
            var result= new List<string>(); 
            result.Add(s)          ;
           // Console.WriteLine("x "+ s+ " y " +result[0]);
            return  result;
        }
        
        var sArr= s.Split("確");
        if(sArr.Length>0)
        return new List<string>(sArr);
        else
        return null;

   }
}
