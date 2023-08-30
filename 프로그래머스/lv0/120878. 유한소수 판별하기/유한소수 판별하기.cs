using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;

            double c = (double)a / b;
            char[] chr = c.ToString().ToCharArray();
            for(int i=0; i<chr.Length; i++)
            {
                if(i<11)
                {
                    answer = 1;
                }
                else
                {
                    answer = 2;
                }
            }
        return answer;
    }
}