using System;
using System.Collections.Generic;
public class Solution {
    public int solution(int num1, int num2) {
        int answer = Convert.ToInt32(Math.Floor(Convert.ToDouble(num1)/num2 * 1000));
        return answer;
    }
}