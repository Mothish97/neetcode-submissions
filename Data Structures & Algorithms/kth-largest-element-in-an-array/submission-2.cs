public class Solution {
    public int FindKthLargest(int[] nums, int k) 
    {
        //var dct = new Dictionary<int,int>();
        var pq = new PriorityQueue<int,int>(Comparer<int>.Create((a,b) => b.CompareTo(a)));
        foreach(var n in nums)
        {
            pq.Enqueue(n,n);
        }
        var ct = 0;
        var ans = 0;

        while(ct < k && pq.Count >0)
        {
            ans = pq.Dequeue();
            //Console.WriteLine($"{ans}");
            //dct[ans]--;
            //if(dct[ans] > 0) pq.Enqueue(ans,ans);
            ct++;
        }
        return ans;
        
    }
}
