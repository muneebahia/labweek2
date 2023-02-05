#include <iostream>
using namespace std;

main()
{
    int size, number, number1;
    cout << "enter the size of the arry:";
    cin >> size;
    bool flag = false;
    int numbers[size];
    for (int idx = 0; idx < size; idx++)
    {
        cout << "enter num1: ";
        cin >> numbers[idx];

        while (numbers[idx] != 0)
        {
            number = numbers[idx] % 10;
            numbers[idx] = numbers[idx] / 10;
            if (number == 7)
            {
                flag = true;
                break;
            }
        }
    }
    if (flag == true)
    {
        cout << "boom!!";
    }
    else
    {
        cout << "not found!!";
    }
}
