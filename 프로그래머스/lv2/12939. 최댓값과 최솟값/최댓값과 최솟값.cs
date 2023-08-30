using System;
public class Solution {
    public string solution(string s)
    {
            string[] s_s = s.Split(' ');

            int[] Nums = new int[2] { Convert.ToInt32(s_s[0]), Convert.ToInt32(s_s[1]) };

            for (int i = 0; i < s_s.Length; i++)
            {
                Nums[1] = Convert.ToInt32(s_s[i]) > Nums[1] ? Convert.ToInt32(s_s[i]) : Nums[1];
                Nums[0] = Convert.ToInt32(s_s[i]) < Nums[0] ? Convert.ToInt32(s_s[i]) : Nums[0];
            }
        string answer = Nums[0] + " " + Nums[1];
        return answer;
    }
}