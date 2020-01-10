n,k = map(int,input().split())
result = 0
l=list(map(int,input().split()))
for i in l:
    if i >=max(1,l[k-1]):
        result+=1
print(result)