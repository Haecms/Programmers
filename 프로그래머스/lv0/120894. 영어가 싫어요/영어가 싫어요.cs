using System;
using System.Text.RegularExpressions;

public class Solution {
    public long solution(string numbers)
    {
        numbers = Regex.Replace(numbers, "zero", "0");
        numbers = Regex.Replace(numbers, "one", "1");
        numbers = Regex.Replace(numbers, "two", "2");
        numbers = Regex.Replace(numbers, "three", "3");
        numbers = Regex.Replace(numbers, "four", "4");
        numbers = Regex.Replace(numbers, "five", "5");
        numbers = Regex.Replace(numbers, "six", "6");
        numbers = Regex.Replace(numbers, "seven", "7");
        numbers = Regex.Replace(numbers, "eight", "8");
        numbers = Regex.Replace(numbers, "nine", "9");

        long answer = long.Parse(numbers);
        return answer;
    }
}