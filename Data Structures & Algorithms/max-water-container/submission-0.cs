public class Solution {
    public int MaxArea(int[] h) 
    {
        var left = 0;
        var right = h.Count()-1;
        var area = 0;

        while(left<=right)
        {
            area = Math.Max(area, Math.Min(h[left],h[right]) * (right - left));

            if(h[left] < h[right])
            {
                left++;
            } 
            else
            {
                right--;
            }
        }
        return area;

    }
}
