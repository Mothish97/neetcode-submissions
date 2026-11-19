public class Solution {
    public int EvalRPN(string[] tok) {

        var stck = new Stack<int>();

        for(int i =0; i<tok.Count();i++)
        {
            if(int.TryParse(tok[i], out int n))
            {
                stck.Push(n);
            }
            else
            {
                var num1 = stck.Pop();
                var num2 = stck.Pop();

                if(tok[i] == "+")
                {
                    stck.Push(num1+num2);
                }
                if(tok[i] == "*")
                {
                    stck.Push(num1*num2);
                }
                if(tok[i] == "/")
                {
                    stck.Push(num2/num1);
                }
                if(tok[i] == "-")
                {
                    stck.Push(num2-num1);
                }
            }
        }

        var res = stck.Pop();
        return res;
        
    }
}
