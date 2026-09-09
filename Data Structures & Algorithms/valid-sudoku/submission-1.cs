public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
        List<char> rowList= new();
        List<char> columnList=new();
        List<char> block=new();
        
        for(int i=0; i< 9; i++)
        {
            
            rowList.Clear();
            columnList.Clear();
            for(int j=0;j<9; j++)
            {
                
                var n=board[i][j];
                
                if(rowList.Contains(n) && n!='.')
                {
                    //Console.WriteLine($"Row already contains{v}");
                    return false;
                }
                rowList.Add(n);
               // Console.WriteLine($"R : {v.ToString()} ");
                //Columns
                n=board[j][i];
                 
                if(columnList.Contains(n) && n!='.')
                {
                    //Console.WriteLine($"Column already contains{v}");
                    return false;
                }
                columnList.Add(n);
                //Console.WriteLine($"C : {v.ToString()} ");
            }
        }
        
        for(int i=0;i<3;i++)
        {
            for(int j=0; j<3;j++)
            {
                //Console.WriteLine("BLOCK");
                block.Clear();
                for(int x=0;x<3;x++)
                {
                    for(int y=0;y<3;y++)
                    {
                        var indX= x+ (i*3);
                        var indY= y+(j*3);

                        var n=board[indX][indY];
                        
                        if(block.Contains(n) && n!='.')
                        {
                           // Console.WriteLine($"Block already contains{v}");
                            return false;
                        }
                        block.Add(n);
                       // Console.WriteLine($"Block : {v.ToString()} ");
                    }
                }
            }
        }

        return true;
    }
}
