public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) 
    {
        //if(position.Count() == 1) return 1;
         var dct = new Dictionary<int,int>();
         for(int i =0; i< position.Count();i++)
         {
            dct.Add(position[i],speed[i]);
         } 

         Array.Sort(position);
         Array.Reverse(position);

        for(int i =0; i< position.Count();i++)
         {
            speed[i] = dct[position[i]];
         }
         var stck = new Stack<float>();
         var ans = 0;

         for(int i =0; i< position.Count();i++)
         {
            var time = (float)(target - position[i])/speed[i];

            if(stck.Count()>0 && stck.Peek()>= time)
            {
            
            }
            else
            {
                ans++;
                
                stck.Clear();
                stck.Push(time);
                Console.WriteLine(stck.Peek().ToString());
            }
           
            

         }

         return ans ;



         }
}


//7 4 1 0
//1 2 2 1
//3 3 4 10