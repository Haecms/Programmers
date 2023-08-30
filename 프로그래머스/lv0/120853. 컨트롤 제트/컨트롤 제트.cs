using System;
using System.Text.RegularExpressions;

public class Solution {
    public double solution(string s)
    {
            s = Regex.Replace(s, "Z", "0.5");
            string[] s_s = s.Split(' ');
            double[] d_s = new double[s_s.Length];
            double answer = 0;
            for(int i=0; i<s_s.Length; i++)
            {
                d_s[i] = double.Parse(s_s[i]);
                answer += d_s[i];
                if (d_s[i] == 0.5)
                {
                    answer -= (d_s[i - 1]+0.5);
                }
            }
    return answer;
    }
}