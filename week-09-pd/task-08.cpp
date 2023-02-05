#include <iostream>
using namespace std;

main()
{

    int size, totaltime;
    cout << "enter the size of the arry:";
    cin >> size;
    int switching_time = 0;
    int time;
    string colour[size];
    for (int idx = 0; idx < size; idx++)
    {
        cout << "enter colour: ";
        cin >> colour[idx];
    }
    for (int idx = 0; idx < size; idx++)
    {

        if (colour[idx] != colour[idx + 1])
        {
            switching_time = switching_time + 1;
        }
    }
    totaltime = (2 * size) + (switching_time - 1);
    cout << totaltime << endl;
}