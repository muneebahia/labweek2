#include <iostream>
using namespace std;
bool check(int pre,int curr,int next);

main()
{
    int size;
    int flag;
    int count = 0;
    cout << "enter the size of arry: ";
    cin >> size;
    int arry[size];

    int num[size];
    for (int i = 0; i < size; i++)
    {
        cout << "enter the num of arrays";
        cin >> num[i];
    }

    for (int idx = 1; idx < size - 1; idx++)
    {
         flag=check(num[idx - 1],num[idx],num[idx + 1]);
        {
            if(flag==true)
            {
            arry[count] = num[idx];
            count++;
            }
        }
    }
    if (count != 0)
    {
        for (int idx = 0; idx < count; idx++)
        {
            cout << arry[idx]<<" ";
        }
    }
    else
    {
        cout << "no peak found";
    }
}

bool check(int pre,int curr,int next)
{
    bool flag=false;

    if(curr>pre && curr>next)
    {
        flag=true;
    }
    return flag;
}
