public class Solution {
    public int CharacterReplacement(string s, int k) 
    {
        var hsh = new int[26];
        var left = 0;
        var right =0;
        var res = 1;
        while(right < s.Length)
        {
            int ind = s[right] - 'A';

            hsh[ind]++;

            var mx = hsh.Max();

            var sum = hsh.Sum();

            if(sum-mx >k)
            {
                var rem = s[left] -'A';
                hsh[rem]--;
                left++;
            }

            right++;
            res = Math.Max(right-left, res);
            
        }
        return res;
    }
}
