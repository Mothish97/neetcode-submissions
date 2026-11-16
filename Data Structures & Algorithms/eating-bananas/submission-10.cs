public class Solution {
    public int MinEatingSpeed(int[] piles, int h) 
    {
        var left = 1; 
        var right = piles.Max();

        while(left < right)
        {
            var mid = left + (right - left) / 2;
            var time = findTime(piles,mid);
            
            if(time>h)
            {
                left = mid+1;
            }
            else
            {
                right = mid;
            }
            

        }
        return left;
        
    }

    public int findTime(int[] bans,int k)
    {
        int ans= 0;
        for(int i =0; i<bans.Count();i++)
        {
            int b = (bans[i] + k - 1) / k;
            ans += b;
        }
        return ans;

    }
}
