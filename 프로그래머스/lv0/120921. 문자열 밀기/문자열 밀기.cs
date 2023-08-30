using System;

public class Solution {
    public int solution(string A, string B)
    {
            int count = 0;
            char temp;
            while(count <= A.Length)
            {
                if (A == B)
                {
                    break;
                }
                else if (A != B && count < A.Length)
                {
                    temp = A[A.Length - 1];
                    A = A.Remove(A.Length - 1);
                    A = string.Concat(temp, A);
                    count++;
                }
                else if(A!=B && count >= A.Length)
                {
                    count = -1;
                    break;
                }
            }
        return count;
    }
}