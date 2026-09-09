public class Solution {
    public bool IsValidSudoku(char[][] board) 
    {
        List<int> rowList= new();
        List<int> columnList=new();
        List<int> block=new();
        int currentColumn = 0;
        for(int i=0; i< 9; i++)
        {
            
            rowList.Clear();
            columnList.Clear();
            for(int j=0;j<9; j++)
            {
                
                var n=board[i][j];
                int v = n-'0';
                if(rowList.Contains(v) && v>0)
                {
                    //Console.WriteLine($"Row already contains{v}");
                    return false;
                }
                rowList.Add(v);
               // Console.WriteLine($"R : {v.ToString()} ");
                //Columns
                n=board[j][i];
                v = n-'0';
                if(columnList.Contains(v) && v>0)
                {
                    //Console.WriteLine($"Column already contains{v}");
                    return false;
                }
                columnList.Add(v);
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
                        int v = n-'0';
                        if(block.Contains(v) && v>0)
                        {
                           // Console.WriteLine($"Block already contains{v}");
                            return false;
                        }
                        block.Add(v);
                       // Console.WriteLine($"Block : {v.ToString()} ");
                    }
                }
            }
        }

        return true;
    }
}
