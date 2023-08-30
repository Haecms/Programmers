using System;
using System.Collections.Generic;
using System.Linq;
public class Solution
{
    public int[] solution(int[] arr)
    {
            int a = arr.Min();
            List<int> ints = new List<int>(arr);

            ints.RemoveAll(s => s == a);
        
            int[] answer = ints.ToArray();
            if(answer.Length == 0)
            {
                Array.Resize(ref answer, answer.Length + 1);
                answer[0] = -1;
            }
        return answer;
    }
}