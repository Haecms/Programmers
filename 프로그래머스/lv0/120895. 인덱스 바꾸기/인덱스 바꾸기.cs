using System;

public class Solution {
    public string solution(string my_string, int num1, int num2)
    {
            my_string = my_string + '5';
            char[] my_chr = my_string.ToCharArray();

            my_chr[my_chr.Length - 1] = my_chr[num1];
            my_chr[num1] = my_chr[num2];
            my_chr[num2] = my_chr[my_chr.Length - 1];

            string answer = new string(my_chr);
            answer = answer.Remove(answer.Length-1);
        return answer;
    }
}