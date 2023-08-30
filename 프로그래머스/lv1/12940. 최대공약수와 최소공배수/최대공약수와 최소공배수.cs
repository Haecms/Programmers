public class Solution {
    public int[] solution(int n, int m) {
                    int Min = 0;
            int Max = 0;

            if (n > m)
            {
                for (int i = m; i > 0; i--)
                {
                    if (m % i == 0 && n % i == 0)
                    {
                        Max = i;
                        break;
                    }
                }
                Min = n;
                while (Min > 0)
                {
                    if (Min % n == 0 && Min % m == 0)
                    {
                        break;
                    }
                    Min++;
                }
            }
            else if(n==m)
            {
                Max = 1;
                Min = n;
            }
            else
            {
                for(int i=n; i>0; i--)
                {
                    if(m%i==0 && n%i==0)
                    {
                        Max = i;
                        break;
                    }
                }
                Min = m;
                while (Min > 0)
                {
                    if(Min%n==0&&Min%m==0)
                    {
                        break;
                    }
                    Min++;
                }
            }
            int[] answer = new int[2];
            answer[0] = Max;
            answer[1] = Min;
        return answer;
    }
}