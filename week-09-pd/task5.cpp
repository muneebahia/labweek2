#include<iostream>
using namespace std;

main()
{ 
    
    int size;
    cout<<"enter the size of the arry:";
    cin>>size;

    int numbers[size];
    int smallest=numbers[0];

    for(int idx=0; idx<size; idx++)
    {
    cout<<"enter num : ";
    cin>> numbers[idx];
    }

        for(int idx=0; idx<size; idx++)
        {
            if(numbers[idx]<smallest)
            {
                smallest=numbers[idx];
            }

        }

     cout<<"smallest num is:"<<smallest;
}

