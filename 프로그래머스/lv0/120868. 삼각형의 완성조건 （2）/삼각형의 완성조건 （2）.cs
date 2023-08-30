using System;

public class Solution {
    public int solution(int[] sides)
    {
        Array.Sort(sides);
        int count = 0;
        int byun1 = 1;
        int byun2 = sides[1];
        
        while(byun1<sides[1])
        {
            if(byun1+sides[0]>sides[1])
            {
                count++;
            }
            byun1 +=1;
        }
        while(byun2>=sides[1] && byun2<sides[0]+sides[1])
        {
            if(byun2<sides[0]+sides[1])
            {
                count++;
            }
            byun2 += 1;
        }


        int answer = count;
        return answer;
    }
}