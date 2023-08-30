using System;

public class Solution {
    public long solution(int a, int b) {
            int c = Math.Abs(a - b);
            long[] array = new long[c+1];
            long answer = 0;
            if (a >= b)
            {
                for (int i = 0; i <= c; i++)
                {

                    array[i] = b;
                    b += 1;
                }
            }
            else if (b > a)
            {
                for (int i = 0; i <= c; i++)
                {
                    array[i] = a;
                    a += 1;
                }
            }
            for (int i = 0; i <= c; i++)
            {
                answer += array[i];
            }
        return answer;
    }
}