#include<iostream>
using namespace std;

main()
{ 
    
    int size;
    cout<<"enter the size of the arry:";
    cin>>size;

    int numbers[size];
    int largest=numbers[0];

    for(int idx=0; idx<size; idx++)
    {
    cout<<"enter num : ";
    cin>> numbers[idx];
    }

        for(int idx=1; idx<size; idx++)
        {
            if(numbers[idx]>largest)
            {
                largest=numbers[idx];
            }

        }

     cout<<"largest num is:"<<largest;
}

