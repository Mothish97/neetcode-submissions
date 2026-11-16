public class Solution {
    public int FindMin(int[] nums) 
    {
        //if(arr.Count)
        var l =0;
        var r = nums.Count()-1;
        var ans = Math.Min(nums[l],nums[r]);

        while(l<r)
        {
            var m = (r+l)/2;
            if(nums[nums.Count()-1] >= nums[m])
            {
                r = m;
            }
            else
            {
                l = m+1;
            }
        }

        return nums[l];
    }
}
