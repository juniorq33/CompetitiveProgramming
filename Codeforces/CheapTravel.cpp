#include <iostream>
#include <math.h>
    
using namespace std;
    
int main()
{
    int n, m, a, b, result;
    
    cin >> n >> m >> a >> b;
    
    int A, B, Ba;
    
    A = n * a;
    B = (n / m) * b;
    Ba = (n % m) * a;
    
    result = min(A, B + min(b, Ba));
    
    cout << result;
    
    
    return 0;
}