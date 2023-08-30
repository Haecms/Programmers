public class Solution {
    public string solution(string s)
    {
        int a = 0;
        int b = 0;
        if(s.Length%2==0)
        {
            a = s.Length/2-1;
            b = s.Length/2;
            return s[a].ToString()+s[b].ToString();
        }
        else
        {
            a = s.Length/2;
            return s[a].ToString();
        }
    }
}