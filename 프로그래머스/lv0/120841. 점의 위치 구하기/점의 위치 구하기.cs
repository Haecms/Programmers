using System;

public class Solution {
    public int solution(int[] dot)
    {
        int position = 0;
            if (dot[0] > 0 && dot[1] > 0)
            {
                position = 1;
            }
            else if (dot[0] < 0 && dot[1] > 0)
            {
                position = 2;
            }
            else if (dot[0] < 0 && dot[1] < 0)
            {
                position = 3;
            }
            else if (dot[0] > 0 && dot[1] < 0)
            {
                position = 4;
            }
        return position;
    }
}