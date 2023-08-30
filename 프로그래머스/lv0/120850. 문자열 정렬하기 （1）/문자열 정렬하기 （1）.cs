using System;
using System.Text.RegularExpressions;

public class Solution {
    public int[] solution(string my_string)
    {
            string b = Regex.Replace(my_string, @"\D", "");
            int[] answer = new int[b.Length];
            
            for(int i=0; i<b.Length; i++)
            {
                answer[i] = b[i] - 48;
            }
        Array.Sort(answer);
        return answer;
    }
}