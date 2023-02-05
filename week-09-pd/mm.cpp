#include <iostream>
using namespace std;

main()
{
    bool isfound = false;
    int size, num;
    cout << "enter the size of the arry:";
    cin >> size;
    int update_arr;
    cout << "enter the num:";
    cin >> update_arr;

    int number[size];
    for (int idx = 0; idx < size; idx++)
    {
        cout << "enter num: ";
        cin >> number[idx];
    }
        for (int idx = 0; idx < size; idx++)
{
        for (int i = 1; i <= update_arr; i++)
        {

            if (number[idx] % 2 == 0)
            {
                isfound = true;
            }
            else
            {
                isfound = false;
            }
            

          
            if (isfound == true)
            {
                number[idx] = number[idx] - 2;
            }
            else
            {
                number[idx] = number[idx] + 2;
            }
        }
        cout << number[idx] << endl;
    }
}
