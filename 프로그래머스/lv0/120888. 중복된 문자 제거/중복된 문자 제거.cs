using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string my_string)
    {
            char[] chr = my_string.ToCharArray();
            List<char> list = new List<char>();
            foreach(char chr2 in chr)
            {
                list.Add(chr2);
            }
            list = list.Distinct().ToList();
            string answer = new string(list.ToArray());
        return answer;
    }
}