#include <iostream>
using namespace std;

main()
{
    char arry[27] = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

    string name;
    int newword;

    cout << "enter string";
    getline(cin, name);

    for (int idx = 0; name[idx] != '\0'; idx++)
    {
        for (int x = 0; x < 26; x++)
        {
            if (name[idx] == arry[x])
            {
                newword = x + 1;
                cout << arry[newword];
            }
        }
        
    }
}
