public class Solution {

    public string Encode(IList<string> strs) 
    {
        if(strs.Count==0)
        return null;
        string result="";
        foreach(var s in strs)
        {
            result+= $"{s}確";
        }
       // Console.WriteLine(result.Length);

        if(result.Length-1>0)
        result= result.Substring(0,result.Length-1);
        else 
        return "";
        return result;

        
    }

    public List<string> Decode(string s) 
    {
        
        if(s==null)
        {
           // Console.WriteLine("Null");
            return new List<string>(); 
        }
        var sArr= s.Split("確");
        Console.WriteLine(sArr.Length);
        if (s== string.Empty)
        {
                   // Console.WriteLine("Empty");
            
            var result= new List<string>(); 
            result.Add(s)          ;
            return  result;             
             
            
        }
        
        
        if(sArr.Length>0)
        return new List<string>(sArr);
        else
        return null;

   }
}
