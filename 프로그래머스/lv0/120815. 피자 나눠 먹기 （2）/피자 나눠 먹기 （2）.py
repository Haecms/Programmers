def solution(n):
    answer = 0
    a = True
    while a==True:
        answer +=1
        if (6*answer)%n == 0:
            a = False
            
    return answer
        
