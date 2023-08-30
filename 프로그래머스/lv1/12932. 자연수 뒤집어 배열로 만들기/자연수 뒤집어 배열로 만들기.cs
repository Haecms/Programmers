using System;
public class Solution {
    public int[] solution(long n)
    {
            char[] char_n = n.ToString().ToCharArray();
            Array.Reverse(char_n);
            int[] answer = new int[char_n.Length];

            for (int i=0; i< char_n.Length; i++)
            {
                answer[i] = int.Parse(char_n[i].ToString());
            }
        return answer;
    }
}