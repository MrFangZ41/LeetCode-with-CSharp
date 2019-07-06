public class Solution {
    public int Reverse(int x) {
        var result=0;
        
        
        while(x!=0)
        {
            int count=x%10;
            x/=10;
            
            if(result>Int32.MaxValue/10||result<Int32.MinValue/10)
            {
                return 0;
            }
            
            result=result*10+count;
        }
        
        return result;
    }
}