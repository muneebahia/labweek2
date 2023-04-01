#include <iostream>
using namespace std;

main()
{
    int size;
    cout << "enter the size of arry: ";
    cin >> size;

    int miles[size];
    for (int i = 0; i < size; i++)
    {
        cout << "enter the miles";
        cin >> miles[i];
    }
    int count=0;
    for (int i = 0; i < size-1; i++)// here we run the loop upto size-1 due to sliding window problem
    {
        if (miles[i+1] > miles[i])
        {
            count++;
        }
    }
    cout<<count;
}


