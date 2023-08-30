using System;

public class Solution {
    public int[] solution(string[] strlist) {
        
                    int[] strCopy = new int[strlist.Length];
            
            for(int i =0; i<strlist.Length; i++)
            {
                strCopy[i] = strlist[i].Length;
            }
            int[] answer = strCopy;
        return answer;
    }
}