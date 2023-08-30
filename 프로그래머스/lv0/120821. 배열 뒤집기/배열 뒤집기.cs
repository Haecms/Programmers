using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int[] answer = new int[num_list.Length];
        for(int i=0; i<num_list.Length; i++)
        {
            answer[i] = num_list[i];
        }
        Array.Reverse(answer);
        return answer;
    }
}