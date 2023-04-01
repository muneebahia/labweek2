#include <iostream>
using namespace std;
main()
{
int sum=0;
int tem=0;
    int cartData[5][5] = {
        {10, 7, 12, 10, 14},
        {18, 11, 15, 17, 2},
        {23, 19, 12, 16, 1},
        {7, 12, 16, 0, 2},
        {3, 5, 6, 2, 1}};

    for (int r = 0; r < 5; r++)
    {
        for (int c = 0; c < 5; c++)
        {
            cout << cartData[r][c]<<",";
        }
        cout<<endl;
    }

    for (int r = 0; r < 5; r++)
    {
        sum=sum+cartData[r][0];

    }
    cout<<sum;

        for (int r = 0; r < 5; r++)
    {
        for (int c = 0; c < 5; c++)
        {
                tem=tem+cartData[r][0];

        }

    }
            cout<<tem;
            

}