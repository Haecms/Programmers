using System;
using System.Text.RegularExpressions;
public class Solution {
    public string solution(string my_string)
    {
        string answer = Regex.Replace(my_string, "a|e|i|o|u", "");
        return answer;
    }
}