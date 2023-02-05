#include <iostream>
using namespace std;

main()
{

    int numbers[4];
    for (int idx = 0; idx < 4; idx++)
    {
        cout << "enter num: ";
        cin >> numbers[idx];
    }
        if (numbers[0] == numbers[1] && numbers[1] == numbers[2] && numbers[2] == numbers[3])

        {
            cout << "true"<<endl;
        }
        else
        {
            cout << "false"<<endl;
        }
    }

