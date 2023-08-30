using System;

public class Solution {
    public string solution(string cipher, int code)
    {
            int a = 0;
            char[] chr = cipher.ToCharArray();
            char[] s = new char[chr.Length / code];
            for (int i = 0; i < chr.Length / code; i++)
            {
                a = code * i + code-1;
                s[i] = chr[a];
            }
            string answer = new string(s);
        return answer;
    }
}