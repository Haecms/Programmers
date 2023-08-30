using System;
public class Solution {
    public long solution(long n) {
        double dx = Math.Sqrt(n);
        long ix = (long)Math.Sqrt(n);

        if(ix == dx)
        {
            return ((ix + 1) * (ix + 1));
        }
        else
        {
            return -1;
        }
    }
}