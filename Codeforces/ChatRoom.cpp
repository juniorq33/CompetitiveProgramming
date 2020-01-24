    #include <iostream>
     
    using namespace std;
     
    int main()
    {
        string s = "";
        cin >> s;
     
        char hello[5] = {'h', 'e', 'l', 'l', 'o'};
     
        int hIdx = 0;
     
        for(int i = 0; i < s.length() && hIdx < 5; i++)
        {
            if(s[i] == hello[hIdx])
            {
                hIdx++;
            }
        }
     
        if(hIdx == 5)
        {
            cout << "YES";
        }
        else
        {
            cout << "NO";
        }
     
     
        return 0;
    }