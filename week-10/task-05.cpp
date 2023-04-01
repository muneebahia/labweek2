#include <iostream>
using namespace std;

main()
{
    int size;
    cout << "enter the size of arry: ";
    cin >> size;
    int volum;
    int count = 0;
    int volume[size];
    for (int i = 0; i < size; i++)
    {
        cout << "enter the number of array";
        cin >> volume[i];
    }
    for (int i = 0; i < size; i = i + 3)
    {
        volum = volume[i] * volume[i + 1] * volume[i + 2];
        count = count + volum;
    }
    cout << count;
}
