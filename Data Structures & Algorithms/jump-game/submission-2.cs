public class Solution {
    public bool CanJump(int[] nums) {
    
    var target = nums.Count()-1;
    
    for(int i= nums.Count()-2; i>=0;i--)
    {
        var reach = nums[i] + i;

        if(reach >= target)
        {
            target = i;
        }
    }

    if(target ==0) return true;
    return false;
    }
}
