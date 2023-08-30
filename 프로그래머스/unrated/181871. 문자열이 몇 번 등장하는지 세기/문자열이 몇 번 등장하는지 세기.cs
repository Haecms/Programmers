using System;

public class Solution {
    public int solution(string myString, string pat) {
        int answer = 0;
        int count = 0;
        for(int i=0; i<myString.Length; i++)
        {
            for(int j=0; j<pat.Length; j++)
            {
                if(myString.Length>i+j)
                {
                    if(myString[i+j]==pat[j])
                    {
                        count++;
                        if(count==pat.Length)
                        {
                            answer++;
                            count=0;
                        }
                    }
                    else
                    {
                        count=0;
                        break;
                    }
                }
            }
        }
        return answer;
    }
}