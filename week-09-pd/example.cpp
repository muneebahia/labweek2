#include<iostream>
using namespace std;
main()
{
    int size;
    cout<<"enter the size of the arry:";
    cin>>size;
    
    int numbers[size];

    for(int idx=0; idx<size; idx++)
    {
    cout<<"enter num1: ";
    cin>> numbers[idx];

    }

    for(int idx=0; idx<size; idx++)
    {
    cout<<numbers[idx]<<" ";
    }
}