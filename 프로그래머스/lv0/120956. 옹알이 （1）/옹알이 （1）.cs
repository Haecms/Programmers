using System;

public class Solution {
    public int solution(string[] babbling)
    {
        int count = 0;
        string get = "";
        for(int i=0; i<babbling.Length; i++)
        {
            babbling[i] = babbling[i].Replace("aya", "x");
            babbling[i] = babbling[i].Replace("ye", "x");
            babbling[i] = babbling[i].Replace("woo", "x");
            babbling[i] = babbling[i].Replace("ma", "x");
            
            get = babbling[i].Replace("x","");
            if(get == "")
            {
                count++;
            }
        }
        int answer = count;
        return answer;
    }
}