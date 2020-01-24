#include <iostream>
#include <stdio.h>
    
using namespace std;
    
int main()
{
    int numButtons, numBulbs, x, y;
    
    scanf("%d" "%d", &numButtons, &numBulbs);
    
    bool arr[numBulbs + 1];
    
    for(int i = 1; i < numBulbs + 1; i++)
    {
        arr[i] = false;
    }
    
    while(numButtons--)
    {
        scanf("%d", &x);
        while(x--)
        {
            scanf("%d" , &y);
            arr[y] = true;
    
        }
    }
    
    for(int i = 1; i < numBulbs + 1; i++)
    {
    
        if(arr[i] == false)
        {
            cout << "NO";
            return 0;
        }
    }
    
    cout << "YES";
    
    return 0;
}