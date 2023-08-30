public class Solution {
    public int solution(int n)
    {
        int answer = 0;
        int count = 1;
        while(count<=n)
        {
            if(n%count==0)
            {
                answer+=count;
            }
            count++;
        }
        return answer;
    }
}