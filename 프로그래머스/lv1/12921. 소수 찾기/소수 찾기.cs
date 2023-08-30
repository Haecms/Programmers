using System;
public class Solution
{
    public int solution(int n)
    {
        int answer = 0;
        for(int i=2; i<=n; i++)
        {
            if (Amuguna(i)) answer++;
        }
        return answer;
    }
    public static bool Amuguna(int x)
    {
        int xr = (int)Math.Sqrt(x);
        for(int i=2; i<=xr; i++)
        {
            if (x%i == 0) return false;
        }
        return true;
    }
}