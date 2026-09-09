public class Solution {

    public string Encode(IList<string> strs) 
    {
        if(strs.Count==0)
        return null;
        string result="";
        result = string.Join("確",strs);
        
       // Console.WriteLine(result);
        if(result.Length-1>=0)
        return result;
        else 
        return "";
    }

    public List<string> Decode(string s) 
    {
        if(s==null)
        {
            return new List<string>(); 
        }
         
        var sArr= s.Split("確");
       // Console.WriteLine(sArr.Length);
        if (s== string.Empty ||!s.Contains("確") )
        {           
            var result= new List<string>(); 
            result.Add(s)          ;
           // Console.WriteLine("x "+ s+ " y " +result[0]);
            return  result;
        }
        
        
        if(sArr.Length>0)
        return new List<string>(sArr);
        else
        return null;

   }
}
