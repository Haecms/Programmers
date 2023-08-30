using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long total_p = price;
        int increase_p = price;
        for(int i=0; i<count-1; i++)
        {
            increase_p = increase_p + price;
            total_p += increase_p;
        }
        if(total_p - money<0)
           return 0;
        return total_p - money;
    }
}