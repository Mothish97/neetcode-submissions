public class Solution {
    public int LastStoneWeight(int[] stones) 
    {
        var pq = new PriorityQueue<int,int>(Comparer<int>.Create((x,y) => y.CompareTo(x)));

        foreach(var n in stones)
        {
            pq.Enqueue(n,n);
        }    

        while(pq.Count >1)
        {
            var s1 = pq.Dequeue();
            var s2 = pq.Dequeue();

            var ans = Math.Abs(s1-s2); 
           // Console.WriteLine(ans.ToString());
            if(ans ==0) continue;
            pq.Enqueue(ans,ans);
        }

        if(pq.Count ==0) return 0;

        return pq.Peek();
    }
}
