public class Solution {
    public int MaxSubArray(int[] nums)
    {
        var cur = 0;
        var res =int.MinValue;
        for(int i =0; i<nums.Count();i++)
        {
            cur += nums[i];
            res = Math.Max(cur,res);
            if(cur <= 0)
            {
                cur = 0;

            }
        }
        return res;
        
    }
}
