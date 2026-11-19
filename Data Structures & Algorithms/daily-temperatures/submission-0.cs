public class Solution {
    public int[] DailyTemperatures(int[] temp) 
    {
        var stck = new Stack<(int val, int ind)>();
        int[] res = new int[temp.Count()];
        for(int i =0; i<temp.Count();i++)
        {

            while(stck.Count > 0 && temp[i]> stck.Peek().val)
            {
                var dt = stck.Pop();
                res[dt.ind] = i-dt.ind;
            }
            stck.Push((temp[i],i));
        }  
        return res;

    }
}
