using System;
using System.Text;

public class Solution {
    public string solution(string X, string Y) {
        int[] i_x = new int[10];
        int[] i_y = new int[10];
        string answer = "";
        
        for(int i=0; i<X.Length; i++)
            i_x[Convert.ToInt32(X[i])-48]++;
        for(int i=0; i<Y.Length; i++)
            i_y[Convert.ToInt32(Y[i])-48]++;
        
        StringBuilder sb = new StringBuilder();
        for(int i=9; i>=0; i--)
        {
            while(i_x[i]>0 && i_y[i]>0)
            {
                sb.Append(i);
                i_x[i]--;
                i_y[i]--;
            }
        }
        if(sb.ToString() == "") answer = "-1";
        else if(sb.ToString().Substring(0,1) == "0") answer = "0";
        else answer = sb.ToString();
        return answer;
    }
}