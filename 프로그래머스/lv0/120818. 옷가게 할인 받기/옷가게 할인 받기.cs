using System;

public class Solution {
    public int solution(int price) {
        double answer = price;
        if(price>=100000)
        {
            if(price<300000)
            {
                answer = answer*0.95;
            }
            else if(price>=300000 && price < 500000)
            {
                answer = answer*0.9;
            }
            else
            {
                answer = answer*0.8;
            }
        }
            
        return (int)answer;
    }
}