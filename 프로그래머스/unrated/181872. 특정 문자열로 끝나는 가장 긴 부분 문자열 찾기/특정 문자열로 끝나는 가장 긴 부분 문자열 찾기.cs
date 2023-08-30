using System;

public class Solution {
    public string solution(string myString, string pat) {
        string answer = "";
        int count = 0;
        int check = 0;
        for(int i=1; i<myString.Length; i++)
        {
            if(count == pat.Length)
            {
                break;
            }
            for(int j=0; j<pat.Length; j++)
            {
                if(myString[myString.Length-i-j] == pat[pat.Length-j-1])
                {
                    count++;
                    if(count==pat.Length)
                    {
                        check=myString.Length-i-j+pat.Length;
                        break;
                    }
                }
                else
                {
                    count=0;
                    break;
                }
            }
        }
        for(int i=0; i<check;i++)
        {
            answer += myString[i];
        }
        return answer;
    }
}