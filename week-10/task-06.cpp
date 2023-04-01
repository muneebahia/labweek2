#include <iostream>
using namespace std;

main()
{
    int size;
    cout << "enter the size of arry: ";
    cin >> size;

    int weight[size];
    for (int i = 0; i < size; i++)
    {
        cout << "enter the weights";
        cin >> weight[i];
    }
    int temp;
    for (int i = 0; i < size; i++)
    {
        for (int x = i + 1; x < size; x++)
        {
            if (weight[i] > weight[x])
            {
                temp = weight[i];
                weight[i] = weight[x];
                weight[x] = temp;
            }
        }
        cout << weight[i] << " ";
    }
}
