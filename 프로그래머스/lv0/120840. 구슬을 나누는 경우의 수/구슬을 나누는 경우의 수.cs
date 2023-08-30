using System;


public class Solution {
    public double solution(double balls, double share)
    {
            double a = balls - share;
            double ball = 1;
            double select = 1;
            double goalho = 1;
            for (int i = 1; i <= balls; i++)
            {
                ball = ball * i;
            }
            for (int i = 1; i <= share; i++)
            {
                select = select * i;
            }
            for (int i = 1; i <= a; i++)
            {
                goalho = goalho * i;
            }
            double answer = ball / select / goalho;
        answer = Math.Round(answer);
        return (double)answer;
    }
}