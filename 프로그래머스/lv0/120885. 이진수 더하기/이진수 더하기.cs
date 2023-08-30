using System;

public class Solution {
    public string solution(string bin1, string bin2) {
            int bin1_2 = Convert.ToInt32(bin1, 2);
            int bin2_2 = Convert.ToInt32(bin2, 2);

            int answer_2 = bin1_2 + bin2_2;
             

        return Convert.ToString(answer_2, 2);
    }
}