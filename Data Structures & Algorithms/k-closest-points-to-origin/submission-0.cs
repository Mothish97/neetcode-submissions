public class Solution {
    public int[][] KClosest(int[][] points, int k) 
    {
        var pq = new PriorityQueue<(int x , int y), double>();
        foreach(var p in points)
        {
            double dx = p[0] - 0;
            double dy = p[1] - 0;
            double distance = Math.Sqrt(dx * dx + dy * dy);
            pq.Enqueue((p[0],p[1]),distance);     
        }

        var res =  new List<int[]>();

        var ct = 0;
        while(ct <k)
        {
            ct++;
            var p = pq.Dequeue();
            res.Add([p.x,p.y]);
        }
        return res.ToArray();
    }
}
