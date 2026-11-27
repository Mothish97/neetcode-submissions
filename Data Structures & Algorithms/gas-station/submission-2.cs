public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) 
    {
        var res = 0;
        var cur =0;
        var tot = 0;
        for(int i=0;i<gas.Count();i++)
        {
            int spnd = gas[i] - cost[i];
            cur += spnd;
            tot += spnd;
            Console.WriteLine($"{cur}");
            if(cur<0)
            {
                res = i+1;
                cur = 0;

            }
        }
        if(tot >=0 ) return res;

        return -1;
        
    }
}
 
//-1 -1 1
