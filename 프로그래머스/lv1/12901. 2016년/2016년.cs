public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        int[] Month = {31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        string[] Weeks = {"THU","FRI","SAT","SUN","MON","TUE","WED"};
        int Days = b;
        for(int i=0; i<a-1; i++)
        {
            Days += Month[i];
        }
        for(int i=0; i<7; i++)
        {
            if(Days%7==i)
            {
                answer = Weeks[i];
            }
        }
        return answer;
    }
}