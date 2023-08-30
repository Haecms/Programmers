using System;
using System.Linq;
public class Solution {
    public string solution(string my_string, int n)
    {
                    char[] arr = my_string.ToArray();
            char[] arr1 = new char[arr.Length*n];
            for(int i =0; i < arr.Length*n; i++)
            {
                if (i < n)
                {
                    arr1[i] = arr[0];
                }
                else if(i < 2 * n && i>=n)
                {
                    arr1[i] = arr[1];
                }
                else if(i < 3 * n && i >= 2*n)
                {
                    arr1[i] = arr[2];
                }
                else if (i < 4 * n && i >= 3*n)
                {
                    arr1[i] = arr[3];
                }
                else if (i < 5 * n && i >= 4*n)
                {
                    arr1[i] = arr[4];
                }
            }
            string answer = new string(arr1);
        return answer;
    }
}