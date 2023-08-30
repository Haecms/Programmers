using System;

public class Solution {
    public int solution(int[,] dots)
    {
            int big_num_x1 = 0;
            int small_num_x2 = 0;
            int big_num_y1 = 0;
            int small_num_y2 = 0;
            
            for(int i=0; i < 4; i++)
            {
                for(int k=0; k<4; k++)
                {
                    if (dots[i,0] > dots[k, 0] && i != k)
                    {
                        big_num_x1 = dots[i,0];
                    }
                    else if (dots[i,0]< dots[k,0] && i != k)
                    {
                        small_num_x2 = dots[i,0];
                    }
                }
            }
            for (int i =0; i<4; i++)
            {
                for(int k= 0; k<4; k++)
                {
                    if (dots[i,1] > dots[k, 1] && i!=k)
                    {
                        big_num_y1 = dots[i, 1];
                    }
                    else if (dots[i, 1] < dots[k, 1] && i != k)
                    {
                        small_num_y2 = dots[i, 1];
                    }
                }
            }
            int answer = (big_num_x1 - small_num_x2) * (big_num_y1 - small_num_y2);
        return answer;
    }
}