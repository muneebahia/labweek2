#include <iostream>
using namespace std;

int array[50];

main()
{
    bool flag = false;
    int size, cycle;
    cout << "enter the cycle: ";
    cin >> cycle;

    cout << "enter the array size: ";
    cin >> size;

    for (int i = 0; i < size; i++)
    {
        cout << "enter the numbers of array";
        cin >> array[i];
    }

    if (size > cycle)
    {
        for (int i = 0; i < size; i++)
        {
            if (array[i] == array[i + cycle])
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
        }
    }
    else
    {
        flag = true;
    }
    cout << flag;
}
