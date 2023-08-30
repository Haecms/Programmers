using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] numlist)
    {
        List<int> siro = new List<int>();
        
        foreach(int a in numlist){
            if(a%n==0){
                siro.Add(a);
            }
        }    

        return siro.ToArray();
    }
}