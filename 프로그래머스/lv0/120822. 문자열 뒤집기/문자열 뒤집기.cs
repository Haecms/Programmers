using System;
using System.Linq;

public class Solution {
    public string solution(string my_string)
    {
        char[] array = my_string.ToArray();
        Array.Reverse(array);
        string answer = new string(array);
        return answer.ToString();
    }
}