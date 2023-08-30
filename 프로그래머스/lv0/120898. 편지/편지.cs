using System;

public class Solution {
    public int solution(string message)
    {
        char[] chr = message.ToCharArray();
        
        int answer = chr.Length*2;
        return answer;
    }
}