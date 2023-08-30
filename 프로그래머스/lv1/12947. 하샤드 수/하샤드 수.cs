public class Solution {
    public bool solution(int x) {
                    int y = 0;
            int x_x = x;
            bool answer = true;

            while (x > 0)
            {
                y = y + x % 10;
                x /= 10;
            }
            if (x_x % y == 0) answer = true;
            else answer = false;
        
        return answer;
    }
}