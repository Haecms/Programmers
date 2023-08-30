using System;

public class Solution {
    public int solution(int[] array, int n)
    {
            Array.Sort(array);
            int answer = 0;
            int compare = 1000;
            
            for(int i=0; i<array.Length; i++)
            {
                
                if(compare>= Math.Abs(n - array[i]))
                {
                    if (compare == Math.Abs(n - array[i]))
                    {
                        continue;
                    }
                    answer = array[i];
                }
                compare = Math.Min(compare, Math.Abs(n - array[i]));
            }
        return answer;
    }
}