using System;
using System.Text.RegularExpressions;
public class Solution {
    public bool solution(string s)
    {
        string s_s = s;
        bool answer = false;
        if(s.Length ==4 || s.Length == 6)
        {
            s_s = Regex.Replace(s_s, @"\D", "");
            if(s_s.Length == s.Length)
            {
                answer = true;
            }
            else
            {
                answer = false;
            }
        }
        return answer;
    }
}