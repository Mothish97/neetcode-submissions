public class Solution {
    public int Search(int[] nums, int target) {
        var l =0;
        var r = nums.Count()-1;
        var mid = -1;
        if(r ==0)
        {
            if(nums[0] == target) return 0;
        }
        while(l < r)
        {
            mid = (r+l)/2;
            Console.WriteLine($"left {nums[l]}  mid {nums[mid]} right {nums[r]} ");
            if(nums[mid] == target) return mid;
             if(nums[l] == target) return l;
              if(nums[r] == target) return r;

            if(nums[l] <= nums[mid])
            {
                if(target >= nums[l] && target < nums[mid])
                {
                    r = mid-1;
                }
                else
                {
                    l = mid+1;
                }
                
            }
            else if(nums[r] >= nums[mid])
            {
                if(target <= nums[r] && target >nums[mid])
                {
                    l = mid+1;
                }
                else
                {
                    r = mid-1;
                }
            }
            //break;

        }
  
        return -1;
    }
}
