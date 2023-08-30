using System;

public class Solution
{
    public int solution(int hp)
    {
        int answer = 0;
        int answer1 = hp/5;
        int answer2 = hp%5/3;
        int answer3 = hp%5%3;

        answer = answer1 + answer2 + answer3;
        return answer;
    }
}