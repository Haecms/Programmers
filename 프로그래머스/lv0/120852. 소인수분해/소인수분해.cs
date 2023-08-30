using System;
using System.Collections.Generic;
using System.Linq;


public class Solution {
    public int[] solution(int n) {
            List<int> number = new List<int>();
            for (int i = 2; i < n + 1; i++)
            {
                while (n % i == 0)
                {
                    number.Add(i);
                    n /= i;
                }
            }
            number = number.Distinct().ToList();
            int[] answer1 = number.ToArray();
            Array.Sort(answer1);
            int[] answer = new int[number.Count];
            answer = answer1;
        return answer;
    }
}