public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {

        var dct = new Dictionary<int,int>();
        for(int n=0; n< numbers.Count();n++)
        {
            var diff =target - numbers[n]  ;
            if(dct.ContainsKey(numbers[n]))
            {
                return new int[]{dct[numbers[n]]+1,n+1};
            }

            dct.TryAdd(diff,n);
        }
        
        return null;
        
    }
}
