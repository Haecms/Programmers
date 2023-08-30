using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[] babbling)
    {
        int answer = 0;
        string check = string.Empty;
        Stack<string> stack = new Stack<string>();
        for (int i = 0; i < babbling.Length; i++)
        {
            babbling[i] = babbling[i].Replace("aya", "A");
            babbling[i] = babbling[i].Replace("ye",  "B");
            babbling[i] = babbling[i].Replace("woo", "C");
            babbling[i] = babbling[i].Replace("ma",  "D");

            check = babbling[i];
            foreach(char b in check)
            {
                stack.Push(b.ToString());
                if(stack.Count >= 2)
                {
                    if(stack.ElementAt(0) == stack.ElementAt(1))
                    {
                        check = "fjdlkfjdksljfladsjfaldsfjkdsjflkads";
                        break;
                    }
                }
            }
            check = check.Replace("A", "");
            check = check.Replace("B", "");
            check = check.Replace("C", "");
            check = check.Replace("D", "");
            stack.Clear();
            if (check == "")
            {
                answer++;
            }
        }
        return answer;
    }
}