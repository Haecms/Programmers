using System;
public class Solution {
    public string solution(string s)
    {
        int[] s_int = new int[s.Length];
        string answer = "";
        for (int i = 0; i < s.Length; i++)
        {
            s_int[i] = (int)s[i];
        }
        Array.Sort(s_int);
        Array.Reverse(s_int);
        char[] s_char = new char[s.Length];
        for (int i = 0; i < s.Length; i++)
        {
            answer += Convert.ToChar(s_int[i]);
        }
        return answer;
    }
}