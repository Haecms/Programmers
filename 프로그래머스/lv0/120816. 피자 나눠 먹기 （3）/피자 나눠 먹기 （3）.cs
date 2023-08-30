using System;

public class Solution {
    public int solution(int slice, int n)
    {
        int answer = 1;
        int pizza = slice;
        while(pizza<n)
        {
            pizza = pizza+slice;
            answer++;
        }
        return answer;
    }
}